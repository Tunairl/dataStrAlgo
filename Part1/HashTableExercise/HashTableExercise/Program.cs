class Program
{
    static void Main(string[] args)
    {
        HashSet<int> set = new HashSet<int>();
        int[] numbers = { 1, 2, 3, 3, 2, 1, 4 };
        foreach (var number in numbers)
        {
            set.Add(number);
        }

        //Console.WriteLine(String.Join(",", set));

        var finder = new CharFinder();

        var ch = finder.FindFirstRepeatedChar("green apple");
        Console.WriteLine(ch);

    }
}
