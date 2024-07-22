class Program
{
    static void Main(string[] args)
    {
        //Dictionary<string, string> dict = new Dictionary<string, string>();
        //dict.Add("123456-A", "Tuna");

        //Console.WriteLine(hash("123456-A"));

        CharFinder charFinder = new CharFinder();

        var a = new int[] { 1, 2, 2, 5, 3, 3, 3, 4, 5, 5, 5, 3, 3};

        Console.WriteLine(charFinder.FindFirstNonRepeatedChar("tunatron"));
        Console.WriteLine(charFinder.FindFirstRepeatedChar("tunatron"));

        Console.WriteLine(charFinder.MostFrequent(a));

    }

    public static int hash(string key)
    {
        int hash = 0;
        foreach (var ch in key.ToCharArray())
        {
            hash += ch;
        }
        return hash;
    }
}

class HashTable
{
    private class Entry
    {
        private int key;
        private string value;

        public Entry(int key, string value)
        {
            this.key = key;
            this.value = value;
        }
    }

    private LinkedList<Entry>[] entries = new LinkedList<Entry>[5];

    //public void Put(int key, string value)
    //{
    //    var index = Hash(key);
    //    if (entries[index] == null)
    //    {
    //        entries[index] = new LinkedList<Entry>();
    //    }

    //    var bucket = entries[index];

    //    foreach (Entry entry in bucket)
    //    {
    //        if (entry.key == key)
    //        {
    //            entry.value = value;
    //            return;
    //        }
    //    }
         
    //    bucket.AddLast(new Entry(key, value));
    ////}

    private int Hash(int key)
    { // Math.abs(...);
        return key % entries.Length;
    }

}
