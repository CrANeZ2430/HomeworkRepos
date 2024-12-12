using Homework2;

Console.WriteLine("\t0 - Exit\n\t1 - Add a book\n\t2 - Show all books" +
                  "\n\t3 - Take a book to the local library\n\t4 - Search for a book by title" +
                  "\n\t5 - Search for a book by author\n\t6 - Search for a book by publishers" +
                  "\n\t7 - Change the publisher of a book");

var books = new List<Book>
{
    new ("Dog book", "Alex", "Cool publisher"),
    new ("Cat book", "John", "Cool publisher"),
    new("Parrot book", "Jack", "Cool publisher")
};
var localBooks = new List<Book>
{
    new ("The book", "Alex", "Kyiv city publisher")
};

var library = new Library(books);
var localLibrary = new Library(localBooks);

while (true)
{
    Console.Write("\nEnter an action number: ");
    var action = Console.ReadLine();
    if (!int.TryParse(action, out var actionNumber) && actionNumber is >= 0 and <= 6)
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

                Console.Write("Enter book title: ");
                var title1 = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(title1))
                    continue;

                Console.Write("Enter book author: ");
                var author1 = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(author1))
                    continue;

                Console.Write("Enter book publisher: ");
                var publisher1 = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(publisher1))
                    continue;

                library.AddBook(title1, author1, publisher1);
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
            Console.WriteLine();

            Console.Write("Enter book title: ");
            var title2 = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(title2))
                continue;

            Console.Write("Enter book author: ");
            var author2 = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(author2))
                continue;

            Console.Write("Enter book publisher: ");
            var publisher2 = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(publisher2))
                continue;

            var book = library.FindBookByAllMeans(title2, author2, publisher2);
            library.TakeBook(localLibrary, book);
            break;
        case 4:
            break;
        case 5:
            break;
        case 6:
            break;
    }
}
