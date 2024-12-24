using System.Collections;
using AnimalHotel.Animals;

namespace AnimalHotel.Hotel;

public class GenericHotel<T> : IEnumerable<T> where T : IAnimal
{
    private int _count = 0;
    private int _capacity = 4;
    private T[] _animals = new T[4];

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

    public void AddAnimal(T animal)
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

    public IEnumerable<T> FindAnimalsByOwnerName(string ownerName)
    {
        return _animals.Where(x => x != null && x.Owner.Name == ownerName);
    }

    public void PrintAnimals()
    {
        Console.WriteLine("Generic Hotel members:");
        for (var i = 0; i < _count; ++i)
            Console.Write($"{_animals[i]} ");
        Console.WriteLine();
    }

    public T this[int index]
    {
        get => _animals[index];
        set => _animals[index] = value;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (var i = 0; i < _count; i++) yield return _animals[i];
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
