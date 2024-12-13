namespace Homework2;

public class Library
{
    private readonly List<Book> _library;

    public Library(List<Book> library)
    {
        _library = library;
    }

    public Library()
    {
        _library = new List<Book>();
    }

    public void AddBook(Book book)
    {
        _library.Add(book);
        if (book is null)
            return;

        SuccessfulBookAddition();
    }

    public void AddBook(string title, string author, string publisher)
    {
        var book = new Book(title, author, publisher);
        _library.Add(book);
        SuccessfulBookAddition();
    }

    public void TakeBook(Library customLibrary, Book book)
    {
        if (book.InUsage)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("This book is currently in use");
            Console.ResetColor();
            return;
        }
        customLibrary.AddBook(book);
        book.InUsage = true;
    }

    public void ShowAllBooks()
    {
        if (_library.Count == 0)
            NoBookError();
        Console.ForegroundColor = ConsoleColor.Blue;
        foreach (var book in _library)
            Console.WriteLine(book.ToString());
        Console.ResetColor();
    }

    public Book FindBookByTitle(string title)
    {
        var book = _library.FirstOrDefault(book => book.Title == title);
        if (book is null)
            NoBookError();

        return book;
    }

    public Book FindBookByAuthor(string author)
    {
        var book = _library.FirstOrDefault(book => book.Author == author);
        if (book is null)
            NoBookError();

        return book;
    }

    public Book FindBookByPublisher(string publisher)
    {
        var book = _library.FirstOrDefault(book => book.Publisher == publisher);
        if (book is null)
            NoBookError();

        return book;
    }

    public Book FindBookByAllMeans(string title, string author, string publisher)
    {
        var book = _library.FirstOrDefault(book => book.Title == title && book.Author == author && book.Publisher == publisher);
        if (book is null)
            NoBookError();

        return book;
    }

    private void SuccessfulBookAddition()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Book was successfully added");
        Console.ResetColor();
    }

    private void NoBookError()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("No book found");
        Console.ResetColor();
    }
}
