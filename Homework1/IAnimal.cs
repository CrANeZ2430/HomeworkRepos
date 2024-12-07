namespace Homework1;

public interface IAnimal
{
    string Name { get; }
    string OwnerName { get; }
    byte Age { get; }

    void SayHello()
    {
        Console.WriteLine("I am default implementation");
    }
}