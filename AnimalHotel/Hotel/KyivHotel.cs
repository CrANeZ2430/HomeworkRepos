using System.Collections;
using AnimalHotel.Animals;

namespace AnimalHotel.Hotel;

public class KyivHotel : IEnumerable<IAnimal>
{
    private int _count = 0;
    private int _capacity = 4;
    private IAnimal[] _animals = new IAnimal[4];

    public void FeedAnimals()
    {
        for (var i = 0; i < _count; i++)
            _animals[i].Eat();
    }

    public void PutAnimalsToSleep()
    {
        for (var i = 0; i < _count; i++)
            _animals[i].Sleep();
    }

    public void AddAnimal(IAnimal animal)
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
            Array.Sort(_animals, 0, _count);
    }

    public IEnumerable<IAnimal> FindAnimalsByOwnerName(string ownerName)
    {
        return _animals.Where(x => x != null && x.Owner.Name == ownerName);
    }

    public void PrintAnimals()
    {
        Console.WriteLine("Kyiv Hotel members:");
        for (var i = 0; i < _count; ++i)
            Console.Write($"{_animals[i]} ");
        Console.WriteLine();
    }

    public IAnimal this[int index]
    {
        get => _animals[index];
        set => _animals[index] = value;
    }

    public IEnumerator<IAnimal> GetEnumerator()
    {
        for (var i = 0; i < _count; i++) yield return _animals[i];
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
