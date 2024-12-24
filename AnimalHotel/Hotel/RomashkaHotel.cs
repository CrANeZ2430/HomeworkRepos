using System.Collections;
using AnimalHotel.Animals;

namespace AnimalHotel.Hotel;

public class RomashkaHotel : IEnumerable
{
    private int _count = 0;
    private int _capacity = 4;
    private object[] _animals = new object[4];

    public void FeedAnimals()
    {
        for (var i = 0; i < _count; i++)
            if (_animals[i] is IAnimal iAnimal) iAnimal.Eat();
    }

    public void PutAnimalsToSleep()
    {
        for (var i = 0; i < _count; i++)
            if (_animals[i] is IAnimal iAnimal) iAnimal.Sleep();
    }

    public void AddAnimal(object animal)
    {
        if (_count == _capacity)
        {
            _capacity *= 2;
            Array.Resize(ref _animals, _capacity);
        }

        _animals[_count++] = animal;
    }

    public void SortAnimals()
    {
        if (_count >= 2)
            Array.Sort(_animals, 0, _count, new AnimalComparer("Romashka Hotel"));
    }

    public void PrintAnimals()
    {
        Console.WriteLine("Romashka Hotel members:");
        for (var i = 0; i < _count; ++i)
            if (_animals[i] is IAnimal iAnimal) Console.Write($"{iAnimal} ");
        Console.WriteLine();
    }

    public IEnumerable<IAnimal> FindAnimalsByOwnerName(string ownerName)
    {
        return _animals.OfType<IAnimal>().Where(x => x.Owner.Name == ownerName);
    }

    public object this[int index]
    {
        get => _animals[index];
        set => _animals[index] = value;
    }

    public IEnumerator GetEnumerator()
    {
        for (var i = 0; i < _count; i++) yield return _animals[i];
    }
}
