namespace AnimalHotel.Animals;

public abstract class AnimalFactory
{
    public static Dog CreateDog(string name, byte age, AnimalColor color, Owner owner)
    {
        return Dog.CreateDog(name, age, color, owner);
    }

    public static Cat CreateCat(string name, byte age, AnimalColor color, Owner owner)
    {
        return Cat.CreateCat(name, age, color, owner);
    }
}
