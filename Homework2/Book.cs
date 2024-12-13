namespace Homework2;

public class Book
{
    private string _publisher;
    private bool _inUsage;

    public Book(string title, string author, string publisher)
    {
        if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(publisher))
            throw new ArgumentException("Book title or author or publisher cannot be null or empty.");
        Title = title;
        Author = author;
        Publisher = publisher;
    }

    public string Title { get; }
    public string Author { get; }

    public string Publisher
    {
        get
        {
            return _publisher;
        }
        private set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Book publisher cannot be null or empty.");
            _publisher = value;
        }
    }

    public bool InUsage
    {
        get
        {
            return _inUsage;
        }
        set
        {
            if (value == false)
                throw new ArgumentException("Book is already in use");

            _inUsage = value;
        }
    }

    public void RenamePublisher(string newPublisher)
    {
        Publisher = newPublisher;
    }

    public override string ToString()
    {
        return $"The book: title - {Title}, author - {Author}, publisher - {Publisher}";
    }
}
