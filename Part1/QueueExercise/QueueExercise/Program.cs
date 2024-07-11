class Program
{
    static void Main(string[] args)
    {
        PriorityQueue queue = new PriorityQueue();
        queue.Add(5);
        queue.Add(3);
        queue.Add(6);
        queue.Add(1);
        queue.Add(4);
        queue.Print();

        while (!queue.isEmpty())
        {
            Console.WriteLine(queue.Remove());
        }
    }
    public static void Reverse(Queue<int> queue)
    {
        PriorityQueue q = new PriorityQueue();
        
        
    }
}

