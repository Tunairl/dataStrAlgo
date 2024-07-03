
class ArrayStack
{
    private int[] items;
    private int top;

    public ArrayStack(int size)
    {
        items = new int[size];
        top = -1;
    }

    public void Push(int item)
    {
        if (IsFull()) throw new StackOverflowException("The stack is full.");

        items[++top] = item;
    }

    public int Pop()
    {
        if (IsEmpty())
        {
            throw new Exception("The stack is empty.");
        }
         
        int temp = items[top--];
        return temp;
    }

    public void Peek()
    {
        int element = items[top];
        Console.WriteLine(element);
    }

    public bool IsEmpty() => top == -1;

    public bool IsFull() => top == items.Length - 1;
}
