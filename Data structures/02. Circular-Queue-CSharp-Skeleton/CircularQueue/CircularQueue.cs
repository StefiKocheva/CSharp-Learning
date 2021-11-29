using System;

public class CircularQueue<T>
{
    private T[] array;
    private int head;
    private int tail;

    public CircularQueue(int capacity = DefaultCapacity)
    {
        this.Capacity = capacity;
        this.array = new T[this.Capacity];
    }

    private const int DefaultCapacity = 4;

    public int Capacity { get; private set; }

    public int Count { get; private set; }

    public void Enqueue(T element)
    {
        if (this.Count >= this.Capacity)
        {
            this.Resize();
        }

        if (this.Count == 0)
        {
            this.head = 0;
            this.tail = 0;
        }

        if (this.tail == this.Capacity - 1)
        {
            this.tail = 0;
        }
        else
        {
            this.tail++;
        }

        this.array[this.tail] = element;

        this.Count++;
    }

    private void Resize()
    {
        var newArray = new T[this.Capacity * 2];
        this.CopyAllElements(newArray);
        this.Capacity *= 2;
        this.array = newArray;
    }

    private void CopyAllElements(T[] newArray)
    {
        for (int i = this.head; i <= this.tail; i++)
        {
            this.array[i] = newArray[i];
        }
    }

    // Should throw InvalidOperationException if the queue is empty
    public T Dequeue()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException();
        }

        if (this.Count == 1)
        {
            this.head = 0;
            this.tail = 0;
        }

        if (this.head == this.Capacity - 1)
        {
            this.head = 0;
        }
        else
        {
            this.head++;
        }

        this.Count--;

        return this.array[this.head--];
    }

    public T[] ToArray()
    {
        var newArray = new T[this.Capacity];
        this.CopyAllElements(newArray);
        this.array = newArray;
        return this.array;
    }
}


public class Example
{
    public static void Main()
    {

        CircularQueue<int> queue = new CircularQueue<int>();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);
        queue.Enqueue(6);

        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        int first = queue.Dequeue();
        Console.WriteLine("First = {0}", first);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        queue.Enqueue(-7);
        queue.Enqueue(-8);
        queue.Enqueue(-9);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        first = queue.Dequeue();
        Console.WriteLine("First = {0}", first);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        queue.Enqueue(-10);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        first = queue.Dequeue();
        Console.WriteLine("First = {0}", first);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");
    }
}
