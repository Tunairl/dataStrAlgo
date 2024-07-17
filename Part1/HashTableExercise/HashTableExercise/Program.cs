class Program
{
    static void Main(string[] args)
    {
        // Key: Employee Number (int)
        // Value: Name (string)

        Dictionary<int, string> dict = new Dictionary<int, string>();
        dict.Add(1, "Tuna");
        dict.Add(2, "Lily");
        dict.Add(3, "Nora");

        //foreach (var kvp in dict)
        //{
        //    Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
        //}

        //var myKey = dict.FirstOrDefault(x => x.Value == "Lily").Key;

        dict.ContainsKey(2); // O(1)
        dict.ContainsValue("Nora"); // O(n)

        //Console.WriteLine(myKey);

        CharFinder finder = new CharFinder();

        Console.WriteLine(finder.FindFirstNonRepeatingChar("aabb"));
    }
}
