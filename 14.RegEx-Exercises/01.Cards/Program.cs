using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(?<=[SHDC]|^)([2-9JQKA]|10)[SHDC]";

            Regex cards = new Regex(pattern);

            MatchCollection matches = cards.Matches(input);

            string[] result = matches.Cast<Match>().Select(card => card.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
