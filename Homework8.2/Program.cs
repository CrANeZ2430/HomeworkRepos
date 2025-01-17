using Homework8._1;

var cts = new CancellationTokenSource();
var token = cts.Token;
var sw = SharedData.Stopwatch;
sw.Start();

var path = SharedData.Path;
var shouldStop = false;
while (true)
{
    await Task.Run(async () =>
    {
        SharedData.IoSemaphore.WaitOne();

        var fileNumbers = File.ReadAllLines(path);
        if (fileNumbers.Any(x => x == "Done"))
        {
            shouldStop = true;
        }

        if (shouldStop)
        {
            SharedData.IoSemaphore.Release();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Done");
            Console.ReadLine();
            return;
        }
        else
        {
            var numbers = fileNumbers.Select(double.Parse);
            var average = AverageAsync(numbers);
            var deviation = StandardDeviationAsync(numbers);
            var mode = ModeAsync(numbers);
            var median = MedianAsync(numbers);

            var taskArray = new Task<double>[] { average, deviation, mode, median };
            var results = await Task.WhenAll(taskArray);
            Console.WriteLine($"Average: {results[0]}; Standard deviation {results[1]}; Mode {results[2]}; Median {results[3]}");
            await Task.Delay(SharedData.Delay);

            SharedData.IoSemaphore.Release();
        }
    });
}

static async Task<double> AverageAsync(IEnumerable<double> numbers)
{
    var task = Task.Run(numbers.Average);
    return await task;
}

static async Task<double> StandardDeviationAsync(IEnumerable<double> numbers)
{
    var average = await AverageAsync(numbers);
    var task = Task.Run(() => Math.Sqrt(numbers.Select(x => Math.Pow(x - average, 2)).Average()));
    return await task;
}

static async Task<double> ModeAsync(IEnumerable<double> numbers)
{
    if (numbers.Distinct().Count() == numbers.Count())
        return 0;
    var mode = Task.Run(() => numbers.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key);
    return await mode;
}

static async Task<double> MedianAsync(IEnumerable<double> numbers)
{
    var sortedNumbers = numbers.OrderBy(x => x);
    var numbersLength = numbers.Count();
    if (numbers.Count() % 2 != 0)
    {
        var median = Task.Run(() => sortedNumbers.ElementAtOrDefault((numbersLength + 1) / 2 - 1));
        return await median;
    }
    else
    {
        var median = Task.Run(() => (sortedNumbers.ElementAtOrDefault(numbersLength / 2 - 1) + sortedNumbers.ElementAtOrDefault(numbersLength / 2)) / 2);
        return await median;
    }
}
