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

    public char FindFirstNonRepeatedChar(string str)
    {
        var dict = new Dictionary<char, int>();

        int count = 0;
        var chars = str.ToCharArray();

        foreach (var ch in chars)
        {
            if (dict.ContainsKey(ch))
            {
                count = dict[ch];
                dict[ch] = count + 1;
                continue;
            }
            dict.Add(ch, 1);
        }

        if (dict.ContainsValue(1))
        {
            return dict.First(x => x.Value == 1).Key;
        }

        return Char.MinValue;
    }

    public char FindFirstRepeatedChar(string str)
    {
        var set = new HashSet<char>();

        var chars = str.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            if (set.Contains(chars[i]))
            {
                return chars[i];
            }

            set.Add(chars[i]);

        }

        return Char.MinValue;
    }

    public char FindFirstRepeatingChar(string str)
    {
        var set = new HashSet<char>();
        var chars = str.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            if (set.Contains(chars[i]))
            {
                return chars[i];
            }

            set.Add(chars[i]);
        }
        return Char.MinValue;
    }

    public int MostFrequent(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        int count = 0;

        foreach (var num in nums)
        {
            if (dict.ContainsKey(num))
            {
                count = dict[num];
                dict[num] = count + 1;
                continue;
            }
            dict.Add(num, 0);
        }

        int max = -1;
        int result = nums[0];

        foreach (var item in dict)
        {
            if (item.Value > max)
            {
                max = item.Value;
                result = item.Key;
            }
        }

        return result;
    }
}