
public class GenericList<T>
{
    //tjeeeeena
    private T[] _item;
    private int _Count;

    public GenericList(int capacity = 4)
    {
        _item = new T[capacity];
        _Count = 0;
    }

    public int Count => _Count;


    public void Add(T item)
    {
        if (_Count == _item.Length)
            Resize();

        _item[_Count++] = item;
        //_item[_Count] = item;
        //_Count++;
    }
    public void Clear()
    {
        for (int i = 0; i < _Count; i++)
        {
            _item[i] = default(T);
        }
        _Count = 0;
    }
    private void Resize()
    {
        int newCapacity = _item.Length * 2;
        T[] newArray = new T[newCapacity];

        for (int i = 0; i < _item.Length; i++)
        {
            newArray[i] = _item[i];

        }
        _item = newArray;
    }
    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= _Count)
                throw new ArgumentOutOfRangeException("index");
            return _item[index];
        }
    }

    // Kommentar NK på rad 57
    //iiiii
    // iiii
    //Kommentar från mig
    // iiii

    //comment from Jonathan


}
//Comment From jonathan