namespace LeetCode
{
    public static class ValidParantheses
    {
        public static bool IsValid(string s)
        {
            var closedParantheses = new Dictionary<char, char>() { { ')', '(' }, { '}', '{' }, { ']', '[' } };
            var stack = new Stack<char>();

            foreach (char c in s)
            {
                if (closedParantheses.TryGetValue(c, out var open))
                {
                    if (stack.TryPeek(out var latest))
                    {
                        if (latest == open) stack.Peek();
                        else return false;
                    }
                    else return false;
                }
                else stack.Push(c);
            }
            return true;
        }
    }
}