namespace Homework6;

public static class Clipboard
{
    private static readonly Queue<string> s_clipboard = new();
    public static object LockerObject { get; } = new();

    public static void Push(string data)
    {
        lock (LockerObject) s_clipboard.Enqueue(data);
    }

    public static string Get()
    {
        lock (LockerObject) return s_clipboard.Dequeue();
    }
}
