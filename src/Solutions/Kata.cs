using System.Linq;

namespace Solutions
{
    public class Kata
    {
        public static string DuplicateEncode(string word)
        {
            word = word.ToLowerInvariant();
            var duplicateChars = word
                .GroupBy(c => c)
                .ToDictionary(g => g.Key, g => g.Count())
                .Where(kvp => kvp.Value > 1)
                .Select(kvp => kvp.Key)
                .ToList();
            var chars = word
                .Select(c => duplicateChars.Contains(c) ? ')' : '(');
            return new string(chars.ToArray());
        }
    }
}
