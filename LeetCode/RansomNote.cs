// 383. Ransom Note

namespace LeetCode
{
    internal static class RansomNote
    {
        internal static bool CanConstruct(string ransomNote, string magazine)
        {
            if (magazine.Length != ransomNote.Length) return false;

            var magazineSorted = magazine.ToCharArray().Order().ToList();
            var noteSorted= ransomNote.ToCharArray().Order().ToList();

            for (int i = 0; i < magazineSorted.Count; i++)
            {
                if (magazineSorted[i] != noteSorted[i]) return false;
            }

            return true;
        }
    }
}
