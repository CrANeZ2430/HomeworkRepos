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
    public AnimalColor Color { get; set; }
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

    public static Cat CreateCat(string name, byte age, AnimalColor color, Owner owner)
    {
        return new Cat(name, age, color, owner);
    }
}
