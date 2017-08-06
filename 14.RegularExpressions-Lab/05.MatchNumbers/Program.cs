using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            string numberStrings = Console.ReadLine();

            MatchCollection numbers = Regex.Matches(numberStrings, pattern);

            string[] resultNumbers = numbers.Cast<Match>().Select(n => n.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(" ", resultNumbers));
        }
    }
}
