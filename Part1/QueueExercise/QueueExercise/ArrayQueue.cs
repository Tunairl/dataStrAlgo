

class ArrayQueue
{
    private int Front;
    private int Rear;
    private int count;
    private int[] items;

    public ArrayQueue(int size)
    {
        items = new int[size];
    }

    public void Enqueue(int item)
    {
        if (count == items.Length)
        {
            throw new OverflowException();
        }

        items[Rear] = item;
        Rear = (Rear + 1) % items.Length;
        count++;
        
    }

    public int Dequeue()
    {
        var item = items[Front];
        items[Front] = 0;
        Front = (Front + 1) % items.Length;
        count--;
        return item;
    }

    public int Peek()
    {
        return items[Front];
    }

    public void Print()
    {
        foreach (var item in items)
        {
            Console.Write(item + " ");
        }
    }

    public bool IsEmpty()
    {
        return count == 0;
    }

    public bool IsFull()
    {
        return count == items.Length;
    }

}


