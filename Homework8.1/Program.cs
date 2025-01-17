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
    await Task.Run(async () =>
    {
        SharedData.IoSemaphore.WaitOne();

        File.AppendAllText(path, $"{new Random().Next(1, 101)}{Environment.NewLine}");
        await Task.Delay(SharedData.Delay);

        SharedData.IoSemaphore.Release();
    });

    if (sw.ElapsedMilliseconds > SharedData.WorkTime)
        break;
}
