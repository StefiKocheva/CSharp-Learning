using System;

public class ArrayList<T>
{
    private T[] array;

    public ArrayList()
    {
        this.Capacity = 4;

        this.array = new T[this.Capacity];
    }

    public int Count { get; private set; }

    public int Capacity { get; private set; }

    public T this[int index]
    {
        get
        {
            if (index >= this.Count || index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            return this.array[index];
        }

        set
        {
            if (index >= this.Count || index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            this.array[index] = value;
        }
    }

    public void Add(T item)
    {
        if (this.Count == this.Capacity)
        {
            this.Resize();
        }

        this.array[this.Count] = item;

        this.Count++;
    }

    public T RemoveAt(int index)
    {
        if (index >= this.Count || index < 0)
        {
            throw new ArgumentOutOfRangeException();
        }

        T[] newArray = new T[this.Count - 1];

        for (int i = index; i < this.Count - 1; i++)
        {
            this.array[i] = this.array[i + 1];
        }

        T element = this.array[index];

        this.Count--;

        for (int i = 0; i < this.Count; i++)
        {
            newArray[i] = this.array[i];
        }

        this.array = newArray;

        return element;
    }

    public void Resize()
    {
        this.Capacity *= 2;

        T[] newArray = new T[this.Capacity];

        for (int i = 0; i < this.Count; i++)
        {
            newArray[i] = this.array[i];
        }

        this.array = newArray;
    }
}
