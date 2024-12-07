namespace Homework1;

public class Horse : IAnimal
{
    public Horse()
    {
        Name = "Thunder";
        OwnerName = "Nobody";
        Age = 0;
        Console.WriteLine($"{nameof(Horse)}: {Name}, Owner: {OwnerName}, Age: {Age}");
    }
    
    public Horse(string name, string ownerName, byte age)
    {
        if (age > 30)
        {
            throw new ArgumentException($"{nameof(Horse)} age must be between 0 and 30");
        }

        if (name == "" || ownerName == "")
        {
            throw new ArgumentException($"{nameof(Horse)} or owner name cannot be empty");
        }

        Name = name;
        OwnerName = ownerName;
        Age = age;
        Console.WriteLine($"{nameof(Horse)}: {Name}, Owner: {OwnerName}, Age: {Age}");
    }

    public string Name { get; }
    public string OwnerName { get; }
    public byte Age { get; }

    public void SayHello()
    {
        Console.WriteLine("Neighhh!");
    }
}