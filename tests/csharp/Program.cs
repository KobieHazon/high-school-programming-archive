using System.Reflection;
using System.Text.Json;

string root = Path.GetFullPath(args[0]);
var catalog = JsonDocument.Parse(File.ReadAllText(Path.Combine(root, "csharp/projects.json")));
int count = 0;

Type Load(string path, string type)
{
    var item = catalog.RootElement.EnumerateArray().Single(p => p.GetProperty("path").GetString() == "csharp/" + path);
    string dll = Path.Combine(root, "csharp", path, "bin/Debug/net10.0", item.GetProperty("assembly").GetString() + ".dll");
    return Assembly.LoadFrom(dll).GetType(type, true);
}
object Call(Type type, object instance, string method, params object[] values)
{
    var types = values.Select(v => v.GetType()).ToArray();
    return type.GetMethod(method, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance, null, types, null).Invoke(instance, values);
}
void Equal(object expected, object actual, string name)
{
    if (!Equals(expected, actual)) throw new Exception($"{name}: expected {expected}, got {actual}");
    count++;
}
Type ProgramFor(string name, string ns) => Load("grade11/recursion/" + name, ns + ".Program");
var sum = ProgramFor("arrsum", "ArrSum");
Equal(0, Call(sum, null, "ArrSum", Array.Empty<int>()), "empty sum");
Equal(2, Call(sum, null, "ArrSum", new int[]{-5, 0, 7}), "mixed sum");
var power = ProgramFor("power", "Power");
Equal(1, Call(power, null, "Power", 7, 0), "zero power");
Equal(-8, Call(power, null, "Power", -2, 3), "negative base");
var digits = ProgramFor("digitcnt", "DigitCnt");
foreach (var test in new[]{(0,1),(1005,4),(-120,3),(int.MinValue,10)})
    Equal(test.Item2, Call(digits, null, "DigitCnt", test.Item1), "digit count");
var digitSum = ProgramFor("sumdigits", "SumDigits");
Equal(0, Call(digitSum, null, "SumDigits", 0), "zero digit sum");
Equal(6, Call(digitSum, null, "SumDigits", 1203), "digit sum");
var occurrences = ProgramFor("countarr", "CountArr");
Equal(0, Call(occurrences, null, "CountArr", Array.Empty<int>(), 3), "empty occurrences");
Equal(3, Call(occurrences, null, "CountArr", new int[]{3,1,3,3}, 3), "occurrences");
var diff = ProgramFor("arrdiff", "ArrDiff");
Equal(true, Call(diff, null, "sidra", Array.Empty<int>()), "empty progression");
Equal(true, Call(diff, null, "sidra", new int[]{9}), "one item progression");
Equal(true, Call(diff, null, "sidra", new int[]{9,6,3,0}), "decreasing progression");
Equal(false, Call(diff, null, "sidra", new int[]{1,2,4}), "not a progression");
var rise = ProgramFor("risearr", "RiseArr");
Equal(true, Call(rise, null, "RiseArr", Array.Empty<int>()), "empty increasing");
Equal(true, Call(rise, null, "RiseArr", new int[]{-5,0,2}), "increasing");
Equal(false, Call(rise, null, "RiseArr", new int[]{1,1}), "strictly increasing");

var stack = Load("grade11/stacks-and-queues/stackbasic", "StackBasic.Stack`1").MakeGenericType(typeof(int));
object s = Activator.CreateInstance(stack);
Equal(true, Call(stack, s, "IsEmpty"), "new stack");
Call(stack, s, "Push", 10); Call(stack, s, "Push", 20); Call(stack, s, "Push", 30);
Equal(30, Call(stack, s, "Top"), "stack top");
Equal(20, Call(stack, s, "GetItemAt", 2), "stack item");
Equal(20, Call(stack, s, "RemoveItemAt", 2), "stack remove middle");
Call(stack, s, "Reverse");
Equal(10, Call(stack, s, "Pop"), "stack reversed first");
Equal(30, Call(stack, s, "Pop"), "stack reversed last");
Equal(true, Call(stack, s, "IsEmpty"), "stack drained");

var queue = Load("grade11/stacks-and-queues/queue", "ConsoleApplication1.Queue`1").MakeGenericType(typeof(int));
object q = Activator.CreateInstance(queue);
Equal(true, Call(queue, q, "IsEmpty"), "new queue");
Call(queue, q, "Insert", 10); Call(queue, q, "Insert", 20); Call(queue, q, "Insert", 30);
Equal(10, Call(queue, q, "Head"), "queue head");
Call(queue, q, "Reverse");
Equal(30, Call(queue, q, "Remove"), "queue reverse first");
Equal(20, Call(queue, q, "Remove"), "queue reverse middle");
Equal(10, Call(queue, q, "Remove"), "queue reverse last");
Equal(true, Call(queue, q, "IsEmpty"), "queue drained");
Call(queue, q, "Insert", 99);
Equal(99, Call(queue, q, "Remove"), "queue reuse");

var student = Load("grade11/objects/student", "ConsoleApplication1.Student");
object learner = Activator.CreateInstance(student, new object[]{"Example", 80, 81});
Equal(80.5, Call(student, learner, "StudentAverage"), "fractional grade average");
Call(student, learner, "SetMathG", 91);
Equal(86.0, Call(student, learner, "StudentAverage"), "updated grade average");
Console.WriteLine($"{count} behavioral assertions passed.");
