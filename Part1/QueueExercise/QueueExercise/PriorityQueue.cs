
class PriorityQueue
{
    private int[] items = new int[5];
    private int count;
    
    public void Add(int item)
    {
        if (IsFull())
        {
             throw new OverflowException();
        }

        var i = ShiftItemsToInsert(item);
        items[i] = item;
        count++;
    }

    public bool IsFull()
    {
        return count == items.Length;
    }

    public int ShiftItemsToInsert(int item)
    {
        int i;
        for (i = count - 1; i >= 0; i--) 
        {
            if (items[i] > item)
            {
                items[i + 1] = items[i];
            }
            else
                break;
        }
        return i;
    }

    public void Print()
    {
        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine(items[i]);
        }
    }

    public int Remove()
    {
        if (isEmpty())
        {
            throw new ArgumentException();
        }

        return items[--count];
    }

    public bool isEmpty()
    {
        return count == 0;
    }

}

