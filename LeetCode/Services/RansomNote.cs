using System.Diagnostics;

namespace LeetCode.Services
{
    public class RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            bool result = true;
            
            char[] ransomNoteArray = ransomNote.ToCharArray();
            char[] magazineArray = magazine.ToCharArray();
            Dictionary<char, int> charListRansomNote = new Dictionary<char, int>();
            Dictionary<char, int> charListMagazine = new Dictionary<char, int>();
            
            foreach (var c in ransomNoteArray)
            {
                if (!charListRansomNote.ContainsKey(c))
                {
                    charListRansomNote[c] = 1;
                }
                else
                {
                    charListRansomNote[c] = charListRansomNote[c] + 1;
                }
            }
            foreach (var c in magazineArray)
            {
                if (!charListMagazine.ContainsKey(c))
                {
                    charListMagazine[c] = 1;
                }
                else
                {
                    charListMagazine[c] = charListMagazine[c] + 1;
                }
            }

            foreach (var r in charListRansomNote)
            {
                if (!charListMagazine.ContainsKey(r.Key) || charListMagazine[r.Key] < r.Value)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}
