using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359([ |-])2\1[0-9]{3}\1[0-9]{4}\b";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);
            List<string> phoneNumbers = new List<string>();

            string[] result = matches.Cast<Match>().Select(p => p.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
