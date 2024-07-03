
class Expression
{
    List<char> leftBrackets = new List<char>(new[] { '(', '{', '[', '<' });
    List<char> rightBrackets = new List<char>(new[] { ')', '}', ']', '>' });

    public bool IsBalanced(string input)
    {
        var stack = new Stack<char>();
        char[] buffer = input.ToCharArray();

        bool IsEmpty() => stack.Count == null;

        if (input == null)
        {
            throw new ArgumentNullException();
        }

        foreach (var ch in buffer)
        {

            if (IsLeftBracket(ch))
            {
                stack.Push(ch);
            }
            else if (IsRightBracket(ch))
            {
                if (stack.Count == 0) return false;
                var top = stack.Pop();

                if (BracketsMatch(top, ch))
                {
                    return false;  
                }
            }
        }
        return stack.Count == 0;
    }

    private bool IsLeftBracket(char ch)
    {

        return leftBrackets.Contains(ch);
    }

    private bool IsRightBracket(char ch)
    {

        return rightBrackets.Contains(ch);
    }
    private bool BracketsMatch(char left, char right)
    {
        // regex  çalış
        // big(o)'ya göre değişebilir

        return (left == ')' && right != '(') ||
               (left == '}' && right != '{') ||
               (left == ']' && right != '[') || 
               (left == '>' && right != '<');
    }
}







