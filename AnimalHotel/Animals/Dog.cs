namespace AnimalHotel.Animals;

public class Dog : IAnimal
{
    public string Name { get; set; }
    
    public Owner Owner { get; private set; }
    
    private Dog(string name, Owner owner)
    {
        Name = name;
        Owner = owner;
    }
    
    public void Bark()
    {
        Console.WriteLine($"{nameof(Dog)} is barking");
    }

    public void Eat()
    {
        Console.WriteLine($"{nameof(Dog)} is eating");
    }

    public void Sleep()
    {
        Console.WriteLine($"{nameof(Dog)} is sleeping");
    }
    
    public static Dog CreateDog(string name, Owner owner)
    {
        return new Dog(name, owner);
    }
}