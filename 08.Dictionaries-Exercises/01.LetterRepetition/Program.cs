using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LetterRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] letters = input.ToCharArray();

            Dictionary<char, int> result = new Dictionary<char, int>();

            foreach (char letter in letters)
            {
                if (!result.ContainsKey(letter))
                {
                    result.Add(letter, 1);
                }
                else
                {
                    result[letter]++;
                }
            }

            foreach (KeyValuePair<char, int> pair in result)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
