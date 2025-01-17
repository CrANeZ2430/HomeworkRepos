using System.Diagnostics;

namespace Homework8._1;

public static class SharedData
{
    public static readonly Semaphore IoSemaphore = new(1, 1, "iosemaphore");
    public static readonly Stopwatch Stopwatch = new();
    public static readonly string Path = @"C:\Temp\numbers.txt";
    public static readonly int Delay = 10;
    public static readonly int WorkTime = 60000;
}
