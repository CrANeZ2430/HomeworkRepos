namespace Homework7;

public static class FileManagement
{
    public static void FileManagementSync(int loopNumber)
    {
        var path = @"C:\Temp\number.txt";
        File.Create(path).Close();
        File.AppendAllText(path, loopNumber.ToString());
        File.Delete(path);
    }

    public static async Task FileManagementAsync(int loopNumber)
    {
        await Task.Run(() =>
        {
            var path = @"C:\Temp\number.txt";
            File.Create(path).Close();
            File.AppendAllText(path, loopNumber.ToString());
            File.Delete(path);
        });
    }
}
