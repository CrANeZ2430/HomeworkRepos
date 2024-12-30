using System.Text;

namespace Homework6;

public class Producer
{
    private string[] _words = [ "World", "Trees", "Houses",
                                "People", "Forest", "Morning",
                                "Cars", "Cats", "Dogs", "Plants" ];

    private string GenerateData()
    {
        var sb = new StringBuilder();
        for (var i = 0; i < 5; i++)
            sb.Append(($"{_words[Random.Shared.Next(_words.Length)]} "));
        return sb.ToString();
    }

    public void PushData()
    {
        Clipboard.Push(GenerateData());
    }
}
