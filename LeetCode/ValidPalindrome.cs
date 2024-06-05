// 125. Valid Palindrome

using System.Text;

namespace LeetCode
{
    internal static class ValidPalindrome
    {
        internal static bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;

            var numerics = new[] {48, 57};
            var letters = new[] {97, 122};
            var input = Encoding.ASCII.GetBytes(s.ToLower());
            var start = 0;
            var end = input.Length - 1;

            while (start <= end)
            {
                if ((input[start] < numerics[0] || input[start] > numerics[1]) &&
                    (input[start] < letters[0] || input[start] > letters[1]))
                {
                    start++;
                    continue;
                }

                if ((input[end] < numerics[0] || input[end] > numerics[1]) &&
                    (input[end] < letters[0] || input[end] > letters[1]))
                {
                    end--;
                    continue;
                }

                if (input[start] != input[end])
                {
                    return false;
                }

                start++;
                end--;
            }

            return true;
        }
    }
}
