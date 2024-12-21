using System.Collections;

namespace Homework4;
public sealed class CustomList<T> : IEnumerable<T>
{
    private T[] _data;
    private int _count;
    private int _capacity;

    private event Action OnExpandedEvent = () =>
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("List has just expanded");
        Console.ResetColor();
    };

    public CustomList()
    {
        _data = new T[4];
        Count = 0;
        Capacity = _data.Length;
    }

    public CustomList(int listCapacity)
    {
        _data = new T[listCapacity];
        Count = 0;
        Capacity = listCapacity;

    }
    public CustomList(T[] data)
    {
        _data = data;
        Count = _data.Length;
        Capacity = _data.Length;
    }

    public int Count
    {
        get => _count;
        private set
        {
            if (value < _count || value > _data.Length)
                throw new ArgumentException("Cannot reduce count of a custom list or make it bigger than the internal array");
            _count = value;
        }
    }

    public int Capacity
    {
        get => _capacity;
        private set
        {
            if (value < _capacity)
                throw new ArgumentException("Cannot reduce capacity of a custom list or make it bigger than the internal array");
            _capacity = value;
        }
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= Count)
                throw new ArgumentOutOfRangeException(nameof(index));
            return _data[index];
        }
        set
        {
            if (index < 0 || index >= Count)
                throw new ArgumentOutOfRangeException(nameof(index));
            _data[index] = value;
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (var i = 0; i < Count; i++)
            yield return _data[i];
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(T element)
    {
        if (Capacity == Count)
        {
            if (Capacity < 4)
                Capacity = 4;
            else
                Capacity *= 2;

            var lastData = _data;
            _data = new T[Capacity];

            Array.Copy(lastData, _data, lastData.Length);

            OnExpandedEvent?.Invoke();
        }

        _data[Count] = element;
        Count++;
    }
}
