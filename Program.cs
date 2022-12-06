using System.Diagnostics;

await DoMyTask();

async Task Test1()
{
    var s = new Stopwatch();
    s.Start();
    await Task.Delay(1500);
    s.Stop();
    Console.WriteLine($"\nTest 1: {s.ElapsedMilliseconds} ms");
}

async Task Test2()
{
    var s = new Stopwatch();
    s.Start();
    await Task.Delay(1500);
    s.Stop();
    Console.WriteLine($"\nTest 2: {s.ElapsedMilliseconds} ms");
}

async Task Test3()
{
    var s = new Stopwatch();
    s.Start();
    await Task.Delay(1500);
    s.Stop();
    Console.WriteLine($"\nTest 3: {s.ElapsedMilliseconds} ms");
}

async Task DoMyTask()
{
    var s = new Stopwatch();
    s.Start();
    var t1 = Test1();
    var t2 = Test2();
    var t3 = Test3();
    await Task.WhenAll(t1, t2, t3);
    s.Stop();
    Console.WriteLine($"\nDelay: {s.ElapsedMilliseconds} ms");
}