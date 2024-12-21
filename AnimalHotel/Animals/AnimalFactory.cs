namespace AnimalHotel.Animals;

public abstract class AnimalFactory
{
    public static Dog CreateDog(string name, Owner owner)
    {
        return Dog.CreateDog(name, owner);
    }

    public static Cat CreateCat(string name, Owner owner)
    {
        return Cat.CreateCat(name, owner);
    }
}
