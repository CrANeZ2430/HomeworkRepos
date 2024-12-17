using Homework3;

int number;
while (true)
{
    Console.Write("Please enter a number of homework: ");
    if (int.TryParse(Console.ReadLine(), out number) && number is > 0 and <= 7) break;
    Console.WriteLine("Enter number of homework between 1 and 7\n");
}

switch (number)
{
    case 1:
        LinqExercises.FindWordsWithA(["apples", "shark", "forest", "artist", "pineapple"]);
        break;
    case 2:
        LinqExercises.CheckForSameNumbers([29, 41, 54, 62, 13], [29, 90, 81, 13, 78]);
        break;
    case 3:
        LinqExercises.CheckForHighestMark([new Student("John", "Stone", 8), new Student("Mary", "Blacksmith", 9),
                                                    new Student("Jack", "Eagle", 11), new Student("Jill", "White", 10),
                                                    new Student("July", "Brown", 12)]);
        break;
    case 4:
        LinqExercises.CheckForAverageCategoryPrice([new Product("Milk", 5.4m, "Milk products"),
                                                    new Product("Yogurt", 2.3m, "Milk products"),
                                                    new Product("Bread", 7.8m, "Bakery"),
                                                    new Product("Wine", 12.7m, "Alcohol"),
                                                    new Product("Buns", 3.6m, "Bakery")]);
        break;
    case 5:
        LinqExercises.CheckEmployeesWorkingForFiveYears([new Employee("Jack", "Hawk", new DateTime(1993, 7, 15), new DateTime(2015, 4, 12)),
                                                         new Employee("Hank", "Schrader", new DateTime(1989, 5, 29), new DateTime(2023, 3, 10)),
                                                         new Employee("Gustavo", "Fring", new DateTime(1997, 9, 14), new DateTime(2017, 1, 30))]);
        break;
    case 6:
        LinqExercises.FilterBooksByYearAndGenre([new Book("1984", "George Orwell", new DateTime(1949, 6, 8), "Dystopia"),
                                                 new Book("Dark forest", "John Stone", new DateTime(2013, 7, 25), "Fantasy"),
                                                 new Book("Imagination", "Mary Vain", new DateTime(2014, 2, 17), "Fantasy")]);
        break;
    case 7:
        LinqExercises.GetCustomersWithOrderOfOneThousandAndMore([
            new Customer("John", "Eagle", "Moon street 64", new Order("Bike", 10500)),
            new Customer("Saul", "Goodman", "Venus street 78", new Order("The Constitution of the USA", 650)),
            new Customer("Jill", "Wolf", "Jupiter street 45", new Order("Phone", 7500))
            ]);
        break;
    default:
        Console.WriteLine("Wrong number of homework");
        break;
}
