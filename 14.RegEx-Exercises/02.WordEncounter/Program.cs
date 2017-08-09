using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text.RegularExpressions;

namespace _02.WordEncounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string filter = Console.ReadLine();
            string filterChar = $"{filter[0]}";
            int filterCharCount = int.Parse(filter[1].ToString());

            List<string> words = new List<string>();

            string sentencePattern = @"^[A-Z].*[.!?]$";
            string wordsPattern = @"\w+";


            string input = Console.ReadLine();

            while (input != "end")
            {
                Regex sentence = new Regex(sentencePattern);
                if (sentence.IsMatch(input))
                {
                    MatchCollection wordsInSentence = Regex.Matches(input, wordsPattern);
                    
                    foreach (Match word in wordsInSentence)
                    {
                        int count = Regex.Matches($"{word}", $@"{filterChar}").Count;
                        if (count >= filterCharCount)
                        {
                            words.Add(word.ToString());
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", words));
        }
    }
}