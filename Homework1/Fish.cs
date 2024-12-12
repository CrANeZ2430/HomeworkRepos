namespace Homework1;

public class Fish : IAnimal
{
    public Fish()
    {
        Name = "Bubbles";
        OwnerName = "Unknown person";
        Age = 0;
        Console.WriteLine($"{nameof(Fish)}: {Name}, Owner: {OwnerName}, Age: {Age}");
    }

    public Fish(string name, string ownerName, byte age)
    {
        if (age > 30)
            throw new ArgumentException($"{nameof(Fish)} age must be between 0 and 30");

        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(ownerName))
            throw new ArgumentException($"{nameof(Fish)} or owner name cannot be empty");

        Name = name;
        OwnerName = ownerName;
        Age = age;
        Console.WriteLine($"{nameof(Fish)}: {Name}, Owner: {OwnerName}, Age: {Age}");
    }

    public string Name { get; }
    public string OwnerName { get; }
    public byte Age { get; }

    public void SayHello()
    {
        Console.WriteLine("Blub blub!");
    }
}
