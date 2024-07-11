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

    public bool IsEmpty()
    {
        return inputStack.Count == 0 && outputStack.Count == 0;
    }
}

