namespace Homework3;

public class Book
{
    public Book(string title, string author, DateTime publicationYear, string genre)
    {
        if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(genre))
            throw new ArgumentException("Title, author and genre are required to be not null or empty");

        Title = title;
        Author = author;
        PublicationYear = publicationYear;
        Genre = genre;
    }

    public string Title { get; }
    public string Author { get; }
    public DateTime PublicationYear { get; }
    public string Genre { get; }

    public override string ToString()
    {
        return $"{Title} by {Author}";
    }
}
