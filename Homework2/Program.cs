using Homework2;

Console.WriteLine("\t0 - Exit\n\t1 - Add a book\n\t2 - Show all books" +
                  "\n\t3 - Take a book to the local library\n\t4 - Search for a book by title" +
                  "\n\t5 - Search for a book by author\n\t6 - Search for a book by publishers" +
                  "\n\t7 - Search for a book by all means\n\t8 - Rename the publisher of a book");

var books = new List<Book>
{
    new("Cooking book", "Alex", "Cool publisher"),
    new("Math book", "John", "Cool publisher"),
    new("History book", "Jack", "Cool publisher")
};

var library = new Library(books);
var localLibrary = new Library();

while (true)
{
    Console.Write("\nEnter an action number: ");
    var action = Console.ReadLine();
    if (!int.TryParse(action, out var actionNumber) && actionNumber is >= 0 and <= 8)
        continue;

    switch (actionNumber)
    {
        case 0:
            Environment.Exit(0);
            break;
        case 1:
            while (true)
            {
                Console.WriteLine();

                Console.Write("Enter a book title: ");
                var additionalBookTitle = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(additionalBookTitle))
                    continue;

                Console.Write("Enter a book author: ");
                var additionalBookAuthor = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(additionalBookAuthor))
                    continue;

                Console.Write("Enter a book publisher: ");
                var additionalBookPublisher = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(additionalBookPublisher))
                    continue;

                library.AddBook(additionalBookTitle, additionalBookAuthor, additionalBookPublisher);
                break;
            }
            break;
        case 2:
            Console.WriteLine("\nList of all library books: ");
            library.ShowAllBooks();
            Console.WriteLine("\nList of all local library books: ");
            localLibrary.ShowAllBooks();
            break;
        case 3:
            while (true)
            {
                Console.WriteLine();

                Console.Write("Enter a book title: ");
                var takingBookTitle = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(takingBookTitle))
                    continue;

                Console.Write("Enter a book author: ");
                var takingBookAuthor = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(takingBookAuthor))
                    continue;

                Console.Write("Enter a book publisher: ");
                var takingBookPublisher = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(takingBookPublisher))
                    continue;

                var book = library.FindBookByAllMeans(takingBookTitle, takingBookAuthor, takingBookPublisher);
                library.TakeBook(localLibrary, book);
                break;
            }
            break;
        case 4:
            while (true)
            {
                Console.WriteLine();

                Console.Write("Enter a book title: ");
                var findingBookTitle = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(findingBookTitle))
                    continue;

                var book = library.FindBookByTitle(findingBookTitle);
                if (book == null)
                    break;

                Console.WriteLine(book.ToString());
                break;
            }
            break;
        case 5:
            while (true)
            {
                Console.WriteLine();

                Console.Write("Enter a book author: ");
                var findingBookAuthor = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(findingBookAuthor))
                    continue;

                var book = library.FindBookByAuthor(findingBookAuthor);
                if (book == null)
                    break;

                Console.WriteLine(book.ToString());
                break;
            }
            break;
        case 6:
            while (true)
            {
                Console.WriteLine();

                Console.Write("Enter a book publisher: ");
                var findingBookPublisher = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(findingBookPublisher))
                    continue;

                var book = library.FindBookByPublisher(findingBookPublisher);
                if (book == null)
                    break;

                Console.WriteLine(book.ToString());
                break;
            }
            break;
        case 7:
            while (true)
            {
                Console.WriteLine();

                Console.Write("Enter book title: ");
                var bookTitle = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(bookTitle))
                    continue;

                Console.Write("Enter book author: ");
                var bookAuthor = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(bookAuthor))
                    continue;

                Console.Write("Enter book publisher: ");
                var bookPublisher = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(bookPublisher))
                    continue;

                var book = library.FindBookByAllMeans(bookTitle, bookAuthor, bookPublisher);
                if (book == null)
                    break;

                Console.WriteLine(book.ToString());
                break;
            }
            break;
        case 8:
            while (true)
            {
                Console.WriteLine();

                Console.Write("Enter book title: ");
                var changingBookTitle = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(changingBookTitle))
                    continue;

                Console.Write("Enter book author: ");
                var changingBookAuthor = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(changingBookAuthor))
                    continue;

                Console.Write("Enter book publisher: ");
                var changingBookPublisher = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(changingBookPublisher))
                    continue;

                var book = library.FindBookByAllMeans(changingBookTitle, changingBookAuthor, changingBookPublisher);
                if (book == null)
                    break;

                Console.Write("Enter a new book publisher: ");
                var newPublisher = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(newPublisher))
                    continue;

                book.RenamePublisher(newPublisher);
                Console.WriteLine(book.ToString());
                break;
            }
            break;
    }
}
