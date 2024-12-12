namespace Homework1;

public class Parrot : IAnimal
{
    public Parrot()
    {
        Name = "Keshia";
        OwnerName = "Unknown person";
        Age = 0;
        Console.WriteLine($"{nameof(Parrot)}: {Name}, Owner: {OwnerName}, Age: {Age}");
    }

    public Parrot(string name, string ownerName, byte age)
    {
        if (age > 30)
            throw new ArgumentException($"{nameof(Parrot)} age must be between 0 and 30");

        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(ownerName))
            throw new ArgumentException($"{nameof(Parrot)} or owner name cannot be empty");

        Name = name;
        OwnerName = ownerName;
        Age = age;
        Console.WriteLine($"{nameof(Parrot)}: {Name}, Owner: {OwnerName}, Age: {Age}");
    }

    public string Name { get; }
    public string OwnerName { get; }
    public byte Age { get; }

    public void SayHello()
    {
        Console.WriteLine("Squawk!");
    }
}
