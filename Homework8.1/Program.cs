using Homework8._1;

var sw = SharedData.Stopwatch;
sw.Start();

var path = SharedData.Path;
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
    SharedData.IOSemaphore.WaitOne();

    File.AppendAllText(path, $"{new Random().Next(1, 10000)}{Environment.NewLine}");
    await Task.Delay(10);

    SharedData.IOSemaphore.Release();

    if (sw.ElapsedMilliseconds > 10000)
        break;
}
