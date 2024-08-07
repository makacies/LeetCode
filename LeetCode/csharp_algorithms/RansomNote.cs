// 383. Ransom Note

namespace LeetCode.csharp_algorithms
{
    internal static class RansomNote
    {
        internal static bool CanConstruct(string ransomNote, string magazine)
        {
            var magazineList = magazine.ToList();
            var counter = 0;

            foreach (var item in ransomNote)
            {
                if (magazineList.Remove(item))
                {
                    counter++;
                }
            }

            return counter == ransomNote.Length;
        }
    }
}
