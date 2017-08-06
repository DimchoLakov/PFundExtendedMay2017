using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.MatchHexadecimalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?:0x)?[0-9A-F]+\b";

            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            string[] hexNumbers = matches.Cast<Match>().Select(n => n.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(" ", hexNumbers));
        }
    }
}
