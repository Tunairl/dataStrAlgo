partial class Program
{
    static void Main(string[] args)
    {
        Queue<int> que = new Queue<int>();

        que.Enqueue(10);
        que.Enqueue(20);
        que.Enqueue(30);

        //foreach (var item in queue)
        //{
        //    Console.WriteLine(item);
        //}

        //var front = queue.Dequeue();

        //Console.WriteLine(front);

        //foreach (var item in queue)
        //{
        //    Console.WriteLine(item);
        //} 

        //Reverse(que);

        //foreach (var item in que)
        //{
        //    Console.WriteLine(item);
        //}


        var queue = new ArrayQueue(3);

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        queue.Dequeue();
        queue.Enqueue(40);
        queue.Dequeue();
        queue.Dequeue();
        queue.Enqueue(50);
        queue.Print();

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

