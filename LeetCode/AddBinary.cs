// 67. Add Binary

namespace LeetCode
{
    internal static class AddBinary
    {
        public static string Add(string a, string b)
        {
            if (a.Length > b.Length) b = new string('0', a.Length - b.Length) + b;
            else if (b.Length > a.Length) a = new string('0', b.Length - a.Length) + a;

            var result = new char[a.Length + 1];
            var carry = false;

            for (var i = a.Length - 1; i >= 0; i--)
            {
                var (lastSymbol, currentCurret) = (a[i], b[i], carry) switch
                {
                    ('0', '0', false) => ('0', false),
                    ('0', '0', true) => ('1', false),
                    ('1', '0', false) or ('0', '1', false) => ('1', false),
                    ('1', '0', true) or ('0', '1', true) => ('0', true),
                    ('1', '1', false) => ('0', true),
                    ('1', '1', true) => ('1', true),
                    _ => throw new ArgumentException(),
                };
                carry = currentCurret;
                result[i + 1] = lastSymbol;
            }
            if (carry) result[0] = '1';

           return result[0] == '\0' ? new string(result[1..]) : new string(result);
        }
    }
}
