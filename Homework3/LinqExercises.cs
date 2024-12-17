namespace Homework3;

public static class LinqExcercises
{
    public static void FindWordsWithA(string[] text)
    {
        var processedText = text.Where(x => x[0] == 'a');
        if (processedText.Count() == 0)
        {
            Console.WriteLine("No words found");
            return;
        }

        Console.WriteLine(string.Join(", ", processedText));
    }
}
