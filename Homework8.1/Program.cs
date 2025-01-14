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
    SharedData.IOMutex.WaitOne();

    File.AppendAllText(path, $"{Random.Shared.Next(1, 10000)}\n");
    await Task.Delay(10);

    SharedData.IOMutex.Release();

    if (sw.ElapsedMilliseconds > 10000)
        break;
}
