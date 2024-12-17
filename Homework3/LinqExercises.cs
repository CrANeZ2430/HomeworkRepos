using System.Text;

namespace Homework3;

public static class LinqExercises
{
    public static void FindWordsWithA(string[] text)
    {
        if (text.Length == 0 || text.All(string.IsNullOrWhiteSpace))
        {
            Console.WriteLine("You have no words");
            return;
        }

        var processedText = text.Where(x => x[0] == 'a');
        if (processedText.Count() == 0)
        {
            Console.WriteLine("No words found that start with 'a'");
            return;
        }

        Console.WriteLine(string.Join(", ", processedText));
    }

    public static void CheckForSameNumbers(int[] numbers1, int[] numbers2)
    {
        if (numbers1.Length == 0 || numbers2.Length == 0)
        {
            Console.WriteLine("You have no numbers in the first or the second array");
            return;
        }

        var processedNumbers = numbers2.Where(x => numbers1.Contains(x));
        if (processedNumbers.Count() == 0)
        {
            Console.WriteLine("There are no matching numbers");
            return;
        }

        Console.WriteLine(string.Join(", ", processedNumbers));
    }

    public static void CheckForHighestMark(Student[] students)
    {
        if (students.Length == 0)
        {
            Console.WriteLine("You have no students");
            return;
        }

        var processedStudent = students.MaxBy(x => x.Mark);

        Console.WriteLine(processedStudent);
    }

    public static void CheckForAverageCategoryPrice(Product[] products)
    {
        if (products.Length == 0)
        {
            Console.WriteLine("You have no products");
            return;
        }

        var productsByCategory = products.GroupBy(x => x.Category);

        var sb = new StringBuilder();
        sb.Insert(0, "Average categories price:");
        foreach (var category in productsByCategory)
        {
            var c = category.Average(x => x.Price);
            sb.Append($"\n{category.First().Category}: {c}");
        }

        Console.WriteLine(sb.ToString());
    }

    public static void CheckEmployeesWorkingForFiveYears(Employee[] employees)
    {
        if (employees.Length == 0)
        {
            Console.WriteLine("You have no employees");
            return;
        }

        var processedEmployees = employees.Where(x => (((DateTime.Now - x.DateOfEmployment).TotalDays) / 365) >= 5);

        if (processedEmployees.Count() == 0)
        {
            Console.WriteLine("There are no employees who work more than 5 years");
            return;
        }

        Console.WriteLine(string.Join(", ", processedEmployees));
    }

    public static void FilterBooksByYearAndGenre(Book[] books)
    {
        if (books.Length == 0)
        {
            Console.WriteLine("You have no books");
            return;
        }

        var processedBooks = books.Where(x => x.PublicationYear.Year > 2010 && x.Genre == "Fantasy");


        if (processedBooks.Count() == 0)
        {
            Console.WriteLine("There are no books which were published in 2010 and with genre \"Fantasy\"");
            return;
        }

        Console.WriteLine(string.Join(", ", processedBooks));
    }

    public static void GetCustomersWithOrderOfOneThousandAndMore(Customer[] customers)
    {
        if (customers.Length == 0)
        {
            Console.WriteLine("You have no customers");
            return;
        }

        var processedCustomers = customers.Where(x => x.Order.Price >= 1000);

        if (customers.Count() == 0)
        {
            Console.WriteLine("There are no customers who ordered for more than 1000");
            return;
        }

        Console.WriteLine(string.Join(", ", processedCustomers));
    }
}
