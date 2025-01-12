
var path = @"C:\Temp\numbers.txt";
while (true)
{

    var fileNumbers = File.ReadAllLines(path);
    var average = await AverageAsync(fileNumbers);
    Console.WriteLine($"Average: {average}");
    await Task.Delay(10);
}

async Task<double> AverageAsync(string[] fileNumbers)
{
    var task = Task.Run(() => fileNumbers.Select(int.Parse).Average());
    return await task;
}
