namespace AnimalHotel.Animals;

public class Cat : IAnimal
{
    private Cat(string name, byte age, AnimalColor color, Owner owner)
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

    public void Meow()
    {
        Console.WriteLine($"{nameof(Cat)} is meowing");
    }

    public void Eat()
    {
        Console.WriteLine($"{nameof(Cat)} is eating");
    }

    public void Sleep()
    {
        Console.WriteLine($"{nameof(Cat)} is sleeping");
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
        return $"Cat {Name}";
    }

    public static Cat CreateCat(string name, byte age, AnimalColor color, Owner owner)
    {
        return new Cat(name, age, color, owner);
    }
}
