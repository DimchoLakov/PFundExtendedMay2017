using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _06.ReplaceATag
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"<a.*href=(""|')(.*)\1>(.*?)<\/a>";
            //string example = @"<a.*?href.*?=(.*)>(.*?)<\/a>";

            string input = Console.ReadLine();

            List<string> list = new List<string>();

            while (input != "end")
            {
                Regex regexpr = new Regex(pattern);
                if (regexpr.IsMatch(input))
                {
                    string replacement = @"[URL href=""$2""]$3[/URL]";
                    input = regexpr.Replace(input, replacement);
                }
                list.Add(input);

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join($"{Environment.NewLine}", list));
        }
    }
}
