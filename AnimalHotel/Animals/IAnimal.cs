namespace AnimalHotel.Animals;

public interface IAnimal
{
    string Name { get; set; }
    byte Age { get; set; }
    AnimalColor Color { get; }

    void Eat();
    void Sleep();
}
