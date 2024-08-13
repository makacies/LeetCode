// 13. Roman to Integer

namespace LeetCode.algorithms
{
    internal class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            var dict = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            var current = 0;
            var result = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                var temp = dict[s[i]];
                if (temp >= current)
                {
                    result += temp;
                    current = temp;
                }
                else
                {
                    result -= temp;
                }
            }

            return result;
        }
    }
}
