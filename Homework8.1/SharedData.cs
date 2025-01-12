using System.Diagnostics;

namespace Homework8._1;

public static class SharedData
{
    public static readonly SemaphoreSlim IoSemaphore = new(1, 1);
    public static readonly Stopwatch Stopwatch = new();
    public static readonly string Path = @"C:\Temp\numbers.txt";
}
