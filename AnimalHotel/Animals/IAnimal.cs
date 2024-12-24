namespace AnimalHotel.Animals;

public interface IAnimal : IComparable<IAnimal>
{
    string Name { get; set; }
    byte Age { get; set; }
    AnimalColor Color { get; }
    Owner Owner { get; }

    void Eat();
    void Sleep();
}
