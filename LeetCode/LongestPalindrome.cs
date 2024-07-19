// 409. Longest Palindrome

namespace LeetCode
{
    public class LongestPalindrome
    {
        public int GetLenght(string s)
        {
            var set = new HashSet<char>();
            var length = 0;

            foreach (char c in s)
            {
                if (set.Remove(c))
                {
                    length += 2;
                }
                else
                {
                    set.Add(c);
                }
            }

            return set.Count() > 0 ? ++ length : length;
        }
    }
}
