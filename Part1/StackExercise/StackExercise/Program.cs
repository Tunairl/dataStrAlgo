
class Program 
{
    static void Main(string[] args)
    {
        //StringReverser reverser = new StringReverser();
        //var str = "mehmet mi";
        //var result = reverser.Reverse(reverser.Reverse("hello world"));
        //Console.WriteLine(result);
        //Console.WriteLine(reverser.Reverse(str));


        //var text = "<1+2)";

        //var expr = new Expression();

        //var result = expr.IsBalanced(text);
        //Console.WriteLine(result);

        var stack = new ArrayStack(3);
        stack.Push(5);
        stack.Push(2);

        stack.Peek();

        Console.WriteLine(stack.Pop());

        stack.Peek();

        Console.WriteLine(stack.IsFull());

        Console.WriteLine(stack);
    }
}

class LinkedListStack
{
    private LinkedList<int> items;
    private LinkedListNode<int> top;
    private LinkedListNode<int> prev;
    private int size = 0;

    public LinkedListStack()
    {
        items = new LinkedList<int>();
        top = null;
    }

    public void Push(int value)
    {
        items.AddLast(value);


    }




}
