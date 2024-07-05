class Program
{
    static void Main(string[] args)
    {

    }
    public static void Reverse(Queue<int> queue)
    {
        var stack = new Stack<int>();

        while (queue.Count() != 0)
        {
            stack.Push(queue.Dequeue());
        }
        while (stack.Count() != 0)
        {
            queue.Enqueue(stack.Pop());
        }
    }
}

class StackQueue
{
    private Stack<int> inputStack;
    private Stack<int> outputStack;

    public StackQueue(int size)
    {
        inputStack = new Stack<int>(size);
        outputStack = new Stack<int>(size);
    }

    public void Enqueue(int item)
    {
        while (outputStack.Count > 0)
        {
            inputStack.Push(outputStack.Pop());
        }

        inputStack.Push(item);

        while (inputStack.Count > 0)
        {
            outputStack.Push(inputStack.Pop());
        }
    }

    public int Dequeue()
    {
        return outputStack.Pop();
    }

    public int Peek()
    {
        return outputStack.Peek();
    }

    //ıupublic bool IsEmpty()
    //{
    //    bool isEmpty = .Count == 0 || retrievalStack.Count == 0;
    //    return isEmpty;
    //}
}

