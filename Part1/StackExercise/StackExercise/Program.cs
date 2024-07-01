
class Program 
{
    static void Main(string[] args)
    {
        //StringReverser reverser = new StringReverser();
        //var str = "mehmet mi";
        //var result = reverser.Reverse(reverser.Reverse("hello world"));
        //Console.WriteLine(result);
        //Console.WriteLine(reverser.Reverse(str));


        var text = "<1+2)";

        var expr = new Expression();

        var result = expr.IsBalanced(text);
        Console.WriteLine(result);
    }
}
