using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            char[] delimiters = new char[] { ' ', ',', '.', '?', '!' };

            string[] wordsToCheck = inputText.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            SortedSet<string> palindromes = new SortedSet<string>();

            foreach (string word in wordsToCheck)
            {
                if (IsPalindrome(word))
                {
                    palindromes.Add(word);
                }
            }
            Console.WriteLine(string.Join(", ", palindromes.OrderBy(x => x)));
        }

        public static bool IsPalindrome(string word)
        {
            int startIndex = 0;
            int endIndex = word.Length - 1;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[startIndex] != word[endIndex])
                {
                    return false;
                }
                startIndex++;
                endIndex--;
            }
            return true;
        }
    }
}
