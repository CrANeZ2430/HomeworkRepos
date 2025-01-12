using System.Diagnostics;

using Homework7;

var sw = new Stopwatch();

// sync method
sw.Start();
for (var i = 0; i < 100; i++)
{
    FileManagement.FileManagementSync(i);
}
sw.Stop();
Console.WriteLine($"Sync: {sw.ElapsedMilliseconds} ms");
sw.Reset();

// async method
sw.Start();
for (var i = 0; i < 100; i++)
{
    await FileManagement.FileManagementAsync(i);
}
sw.Stop();
Console.WriteLine($"Async: {sw.ElapsedMilliseconds} ms");
