using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.BoomingCannon
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] distanceAndCount = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int skipCount = distanceAndCount[0];
            int takeCount = distanceAndCount[1];

            string pattern = @"(?<=\\<<<)[^\\<]+";

            List<string> result = new List<string>();

            string input = Console.ReadLine();

            Regex cannons = new Regex(pattern);

            MatchCollection matches = cannons.Matches(input);

            foreach (Match match in matches)
            {
                string target = string.Empty;
                if(takeCount >= 0 && skipCount + takeCount < match.Value.Length)
                {
                    target = match.Value.Substring(skipCount, takeCount);
                }
                else if (takeCount >= 0 && skipCount + takeCount >= match.Value.Length)
                {
                    if (skipCount <= match.Value.Length)
                    {
                        target = match.Value.Substring(skipCount);
                    }
                }
                if (target != string.Empty)
                {
                    result.Add(target);
                }
            }
            Console.WriteLine(string.Join(@"/\", result));
        }
    }
}
