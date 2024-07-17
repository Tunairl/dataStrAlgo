public class CharFinder
{
    public char FindFirstNonRepeatingChar(string str)
    {
        var charDict = new Dictionary<char, int>();
        int count = 0;
        var chars = str.ToCharArray();
        foreach (var ch in chars)
        {
            if (charDict.Keys.Contains(ch))
            {
                count = charDict[ch];
                charDict[ch] = count + 1;
                continue;
            }
            charDict.Add(ch, 1);
        }

        if (charDict.Values.Contains(1))
        {
            return charDict.First(x => x.Value == 1).Key;
        }
        return Char.MinValue;
    }
}