"""List, build or run independent C# teaching examples."""
import argparse
import json
import os
from pathlib import Path
import subprocess
from concurrent.futures import ThreadPoolExecutor

ROOT = Path(__file__).resolve().parents[1]
PROJECTS = json.loads((ROOT / 'csharp/projects.json').read_text())
ENV = {**os.environ, 'DOTNET_CLI_TELEMETRY_OPTOUT': '1', 'DOTNET_NOLOGO': '1'}


def build(project):
    result = subprocess.run(['dotnet', 'build', str(ROOT / project['path'] / 'Exercise.csproj'), '--nologo', '-v:q'], env=ENV, capture_output=True, text=True, timeout=120)
    print(('OK ' if result.returncode == 0 else 'FAIL ') + project['path'], flush=True)
    if result.returncode:
        print(result.stdout + result.stderr)
    return result.returncode


def main():
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument('command', choices=['list', 'build', 'run'])
    parser.add_argument('project', nargs='?', help='Exact project directory from list')
    parser.add_argument('--include-reference', action='store_true')
    args = parser.parse_args()
    if args.command == 'run':
        project = next((p for p in PROJECTS if p['path'] == args.project), None)
        if project is None or project['status'] != 'buildable':
            parser.error('Choose a buildable executable project from list.')
        return subprocess.call(['dotnet', 'run', '--project', str(ROOT / project['path'] / 'Exercise.csproj')], env=ENV)
    selected = [p for p in PROJECTS if args.include_reference or p['kind'] == 'exercise']
    if args.project:
        selected = [p for p in selected if p['path'] == args.project]
        if not selected:
            parser.error('Unknown project; references require --include-reference.')
    if args.command == 'list':
        for project in selected:
            print(f"{project['status']:10} {project['path']} {project['note']}")
        return 0
    drafts = [p for p in selected if p['status'] == 'draft']
    for project in drafts:
        print('DRAFT (not built): ' + project['path'] + ' — ' + project['note'])
    selected = [p for p in selected if p['status'] != 'draft']
    with ThreadPoolExecutor(max_workers=4) as pool:
        results = list(pool.map(build, selected))
    print(f"{results.count(0)}/{len(results)} projects built; {len(drafts)} drafts excluded.")
    return int(any(results))


if __name__ == '__main__':
    raise SystemExit(main())
