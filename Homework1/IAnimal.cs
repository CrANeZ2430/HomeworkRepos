namespace Homework1;

public interface IAnimal
{
    string Name { get; }
    string OwnerName { get; }

    void SayHello()
    {
        Console.WriteLine("I am default implementation");
    }
}