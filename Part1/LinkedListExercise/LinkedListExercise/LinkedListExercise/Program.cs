class Program
{
    static void Main(string[] args)
    {
        var list = new LinkedList();
        list.addLast(10);
        list.addLast(20);
        list.addLast(30);
        list.addFirst(3);
        


        //Console.WriteLine(list.contains(5));

        var array = list.toArray();
        list.reverse();
    }
}