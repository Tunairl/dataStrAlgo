class StringReverser 
{
    public string Reverse(string str)
    {
        if (str == null)
        {
            throw new ArgumentNullException();
        }

        Stack<char> stack = new Stack<char>();

        //String str = "abcd";

        foreach (var ch in str.ToCharArray())
        {
            stack.Push(ch);
        }

        var reversed = new System.Text.StringBuilder();
        while (stack.Count() != 0)
        {
            reversed.Append(stack.Pop());
        }

        return reversed.ToString();

    }
}
