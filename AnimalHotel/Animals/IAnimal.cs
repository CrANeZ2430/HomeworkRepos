namespace AnimalHotel.Animals;

public interface IAnimal
{
    string Name { get; set; }
    
    void Eat();
    
    void Sleep();
}