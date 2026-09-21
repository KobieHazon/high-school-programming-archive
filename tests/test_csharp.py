"""Execute console programs and check actual outputs, not source-file structure."""
import json
import os
from pathlib import Path
import subprocess
import unittest

ROOT = Path(__file__).resolve().parents[1]
PROJECTS = {p['path']: p for p in json.loads((ROOT / 'csharp/projects.json').read_text())}
ENV = {**os.environ, 'DOTNET_CLI_TELEMETRY_OPTOUT': '1', 'DOTNET_NOLOGO': '1'}


def run(path, stdin=''):
    path = 'csharp/' + path
    dll = ROOT / path / 'bin/Debug/net10.0' / (PROJECTS[path]['assembly'] + '.dll')
    result = subprocess.run(['dotnet', str(dll)], input=stdin, capture_output=True, text=True, timeout=15, env=ENV)
    if result.returncode:
        raise AssertionError(result.stdout + result.stderr)
    return result.stdout.strip()


class ConsoleTests(unittest.TestCase):
    def test_recursion_examples(self):
        for name, expected in [('arrsum','20'), ('power','25'), ('countarr','4'), ('sumdigits','10'), ('risearr','True'), ('arrdiff','True'), ('digitcnt','8')]:
            with self.subTest(name=name):
                self.assertEqual(run('grade11/recursion/' + name), expected)

    def test_sum_between_in_both_orders(self):
        for stdin in ['4\n12\n', '12\n4\n']:
            self.assertTrue(run('grade10/basics/sum-num-between-34', stdin).endswith(':72'))

    def test_sum_single_value(self):
        self.assertTrue(run('grade10/basics/sum-num-between-34', '5\n5\n').endswith(':5'))

    def test_word_count(self):
        for text, expected in [('Apple banana apricot ', 2), ('',0), ('a A b',2)]:
            self.assertTrue(run('grade10/strings/string3', text+'\n').endswith(': '+str(expected)))

    def test_password_retry(self):
        self.assertEqual(run('grade10/strings/bstring6', 'abc\nABC123\n'), 'Good Password')

    def test_row_maxima_include_negative_values(self):
        output = run('grade10/arrays/tr1', '2\n2\n-5\n-2\n-1\n-9\n')
        self.assertIn('line is:-2 and its location is: 0,1', output)
        self.assertIn('line is:-1 and its location is: 1,0', output)

    def test_file_objects_merge(self):
        output = run('grade10/objects/object2', 'one\ntxt\n3\n2020\nfalse\nabc\ntwo\ntxt\n2\n2021\nfalse\nde\nmerged\n')
        self.assertIn('name is merged, type: txt, size: 5', output)
        self.assertIn('content: abcde', output)

    def test_file_objects_reject_different_types(self):
        self.assertIn('Not both are the same type', run('grade10/objects/object2', 'one\ntxt\n3\n2020\nfalse\nabc\ntwo\nlog\n2\n2021\nfalse\nde\n'))

    def test_linked_list_prints_all_nodes(self):
        output = run('grade11/linked-lists/intnode', '3\n30\n20\n10\n')
        for index, value in enumerate([10,20,30], 1):
            self.assertIn(f'hulia {index} is - {value}.', output)

    def test_integer_partitions(self):
        self.assertEqual(run('grade12/algorithms/coinchangedirect'), '190569291')

    def test_prime_partitions(self):
        values = run('grade12/algorithms/coin-changing-logic').split()
        self.assertEqual(values[:-1], [str(n) for n in [2,3,5,7,11,13,17,19,23,29,31,37,41,43,47,53,59,61,67,71,73,79,83,89,97]])
        self.assertEqual(values[-1], '71')

    def test_data_structure_and_recursion_boundaries(self):
        result = subprocess.run(['dotnet','run','--project',str(ROOT/'tests/csharp/Behavior.csproj'),'--',str(ROOT)],capture_output=True,text=True,env=ENV,timeout=120)
        self.assertEqual(result.returncode, 0, result.stdout + result.stderr)
        self.assertIn('35 behavioral assertions passed.', result.stdout)


if __name__ == '__main__':
    unittest.main()
