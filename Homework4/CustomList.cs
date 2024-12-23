using System.Collections;

namespace Homework4;
public sealed class CustomList<T> : IEnumerable<T>
{
    private T[] _data;
    private int _count;
    private int _capacity;

    public CustomList()
    {
        _data = new T[4];
        _count = 0;
        _capacity = _data.Length;
    }

    public CustomList(int listCapacity)
    {
        _data = new T[listCapacity];
        _count = 0;
        _capacity = listCapacity;

    }
    public CustomList(T[] data)
    {
        if (data.Length == 0)
            throw new ArgumentNullException("data");

        _data = data;
        _count = _data.Length;
        _capacity = _data.Length;
    }

    private event Action OnExpandedEvent = () =>
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("List has just expanded");
        Console.ResetColor();
    };

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= _count)
                throw new ArgumentOutOfRangeException(nameof(index));
            return _data[index];
        }
        set
        {
            if (index < 0 || index >= _count)
                throw new ArgumentOutOfRangeException(nameof(index));
            _data[index] = value;
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (var i = 0; i < _count; i++)
            yield return _data[i];
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(T element)
    {
        if (_capacity == _count)
        {
            _capacity *= 2;
            var lastData = _data;
            _data = new T[_capacity];

            Array.Copy(lastData, _data, lastData.Length);

            OnExpandedEvent?.Invoke();
        }

        _data[_count] = element;
        _count++;
    }
}
