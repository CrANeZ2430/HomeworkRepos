using System.Diagnostics;

var sw = new Stopwatch();
sw.Start();

var path = @"C:\Temp\numbers.txt";
if (File.Exists(path))
{
    File.Delete(path);
    File.Create(path).Close();
}
else
{
    File.Create(path).Close();
}

while (true)
{
    File.AppendAllText(path, $"{Random.Shared.Next(1, 10000)}\n");
    await Task.Delay(100);
    if (sw.ElapsedMilliseconds > 10000)
        break;
}
