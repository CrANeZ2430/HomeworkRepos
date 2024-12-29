namespace Homework6;

public class Consumer
{
    public void ProcessData()
    {
        lock (Clipboard.LockerObject)
        {
            if (!File.Exists(@"C:\Temp\data.txt"))
                File.Create(@"C:\Temp\data.txt").Dispose();

            var data = Clipboard.Get();
            File.AppendAllText(@"C:\Temp\data.txt", data + Environment.NewLine);
        }
    }
}
