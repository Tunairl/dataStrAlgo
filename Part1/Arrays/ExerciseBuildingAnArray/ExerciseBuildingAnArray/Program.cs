using System.Runtime.CompilerServices;

partial class Program
{

    static void Main(string[] args)
    {
        var numbers = new Array(4);
        numbers.insert(10);
        numbers.insert(20);
        numbers.insert(30);
        numbers.insert(40);
        numbers.insert(50);

        
        Console.WriteLine(numbers.indexOf(10));
        Console.WriteLine(numbers.indexOf(15));
        numbers.print();

    }
}