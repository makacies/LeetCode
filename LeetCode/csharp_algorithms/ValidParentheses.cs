// 20. Valid Parentheses

namespace LeetCode.csharp_algorithms
{
    public static class ValidParentheses
    {
        public static bool IsValid(string s)
        {
            var closedParentheses = new Dictionary<char, char>() { { ')', '(' }, { '}', '{' }, { ']', '[' } };
            var stack = new Stack<char>();

            foreach (char c in s)
            {
                if (closedParentheses.TryGetValue(c, out var open))
                {
                    if (stack.TryPop(out var latest))
                    {
                        if (latest != open) return false;
                    }
                    else return false;
                }
                else stack.Push(c);
            }

            return stack.Count == 0;
        }
    }
}