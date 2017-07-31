using System;
using System.Threading;

namespace _07.CapitalizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiters = new char[] { ' ', '~', '+', '_', '!', '"', '#', ':', ';', '(', ')', '{', '}', '[', ']',
                '%', '$', '&', '\\', '/', '=', '|', '*','^', '?', '-', ',','<', '>', '.'};

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] words = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                words = Capitalize(words);

                Console.WriteLine(string.Join(", ", words));

                input = Console.ReadLine();
            }

        }

        public static string[] Capitalize(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                string firstLetter = words[i].Substring(0, 1).ToUpper();
                string allOtherLetters = string.Empty;
                if (words[i].Length > 1)
                {
                    allOtherLetters = words[i].Substring(1, words[i].Length - 1).ToLower();
                }
                string newWord = firstLetter + allOtherLetters;
                words[i] = newWord;
            }
            return words;
        }
    }
}
