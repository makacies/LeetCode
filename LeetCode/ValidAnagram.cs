// 242. Valid Anagram

namespace LeetCode
{
    internal static class ValidAnagram
    {
        internal static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            var dict = new Dictionary<char, ushort>();

            foreach (var letter in s)
            {
                if (!dict.TryAdd(letter, 1))
                {
                    dict[letter] += 1;
                }
            }

            foreach (var letter in t)
            {
                if (dict.TryGetValue(letter, out _))
                {
                    dict[letter] -= 1;
                    if (dict[letter] == 0)
                    {
                        dict.Remove(letter);
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
