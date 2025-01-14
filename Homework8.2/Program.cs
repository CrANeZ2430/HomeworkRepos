using Homework8._1;

var sw = SharedData.Stopwatch;
sw.Start();

var path = SharedData.Path;
while (true)
{
    SharedData.IOMutex.WaitOne();

    var fileNumbers = File.ReadAllLines(path);
    var average = await AverageAsync(fileNumbers);
    Console.WriteLine($"Average: {average}");
    await Task.Delay(10);

    SharedData.IOMutex.Release();

    if (sw.ElapsedMilliseconds > 10000)
        break;
}

Console.ReadLine();

async Task<double> AverageAsync(string[] fileNumbers)
{
    var task = Task.Run(() => fileNumbers.Select(int.Parse).Average());
    return await task;
}
