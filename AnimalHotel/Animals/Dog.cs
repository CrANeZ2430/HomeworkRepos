namespace AnimalHotel.Animals;

public class Dog : IAnimal
{
    private Dog(string name, byte age, AnimalColor color, Owner owner)
    {
        Name = name;
        Age = age;
        Color = color;
        Owner = owner;
    }

    public string Name { get; set; }
    public byte Age { get; set; }
    public AnimalColor Color { get; }
    public Owner Owner { get; private set; }

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
    public int CompareTo(IAnimal? other)
    {
        if (Age > other.Age)
            return 1;
        if (Age < other.Age)
            return -1;
        return 0;
    }

    public override string ToString()
    {
        return $"Dog {Name}";
    }

    public static Dog CreateDog(string name, byte age, AnimalColor color, Owner owner)
    {
        return new Dog(name, age, color, owner);
    }
}
