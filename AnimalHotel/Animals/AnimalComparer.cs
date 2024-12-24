using System.Collections;

namespace AnimalHotel.Animals;

public class AnimalComparer(string hotelName) : IComparer
{
    public int Compare(object? x, object? y)
    {
        if (x is IAnimal iAnimal1 && y is IAnimal iAnimal2)
        {
            if (iAnimal1.Age > iAnimal2.Age)
                return 1;
            if (iAnimal1.Age < iAnimal2.Age)
                return -1;
            return 0;
        }

        throw new ArgumentException($"{hotelName} member cannot be null");
    }
}
