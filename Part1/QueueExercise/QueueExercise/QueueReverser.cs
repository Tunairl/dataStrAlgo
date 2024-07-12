class QueueReverser
{
    public static void Reverse(Queue<int> q, int k)
    {
        if (k < 0 || k > q.Count)
        {
            throw new ArgumentException();
        }

        var stack = new Stack<int>();

        for (int i = 0; i < k; i++)
        {
            stack.Push(q.Dequeue());
        }
        
        while (stack.Count != 0)
        {
            q.Enqueue(stack.Pop());
        }

        for (int i = 0; i < q.Count - k; i++)
        {
            q.Enqueue(q.Dequeue());
        }
    }


}

