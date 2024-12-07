namespace Homework1;

public class Cat : IAnimal
{
    public Cat()
    {
        Name = "Barsik";
        OwnerName = "Unknown person";
        Age = 0;
        Console.WriteLine($"{nameof(Cat)}: {Name}, Owner: {OwnerName}, Age: {Age}");
    }
    
    public Cat(string name, string ownerName, byte age)
    {
        if (age > 30)
        {
            throw new ArgumentException($"{nameof(Cat)} age must be between 0 and 30");
        }

        if (name == "" || ownerName == "")
        {
            throw new ArgumentException($"{nameof(Cat)} or owner name cannot be empty");
        }

        Name = name;
        OwnerName = ownerName;
        Age = age;
        Console.WriteLine($"{nameof(Cat)}: {Name}, Owner: {OwnerName}, Age: {Age}");
    }

    public string Name { get; }
    public string OwnerName { get; }
    public byte Age { get; }

    public void SayHello()
    {
        Console.WriteLine("Meow!");
    }
}