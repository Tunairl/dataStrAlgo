class Program
{
    static void Main(string[] args)
    {
        Queue<int> q2 = new Queue<int>();

        q2.Enqueue(10);
        q2.Enqueue(20);
        q2.Enqueue(30);
        q2.Enqueue(40);
        q2.Enqueue(50);

        QueueReverser.Reverse(q2, 3);

        for (int i = 0; i < q2.Count; i++)
        {
            int val = q2.Peek();
            Console.WriteLine(val);
            q2.Enqueue(q2.Dequeue());
        }

    }
}
    

