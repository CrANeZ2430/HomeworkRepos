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
    await SharedData.IoSemaphore.WaitAsync();
    File.AppendAllText(path, $"{Random.Shared.Next(1, 10000)}\n");
    await Task.Delay(100);
    SharedData.IoSemaphore.Release();

    if (sw.ElapsedMilliseconds > 10000)
        break;
}
