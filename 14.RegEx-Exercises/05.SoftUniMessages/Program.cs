using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _05.SoftUniMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            string pattern = @"^(?<first>\d+)(?<content>[A-Za-z]+)(?<second>\d+)$";

            int count = 1;

            while (true)
            {
                if (count % 2 != 0)
                {
                    input = Console.ReadLine();
                }
                else
                {
                    int searchedLength = int.Parse(Console.ReadLine());

                    Regex regex = new Regex(pattern);
                    Match match = regex.Match(input);

                    var content = match.Groups["content"];

                    if (content.Length == searchedLength)
                    {
                        string firstGroup = match.Groups["first"].ToString();
                        string secondGroup = match.Groups["second"].ToString();

                        string result = FormStringFromIndexes(content.ToString(), firstGroup, secondGroup);
                        Console.WriteLine($"{match.Groups["content"]} = {result}");
                    }
                }
                if (input == "Decrypt!")
                {
                    break;
                }
                count++;
            }

        }

        public static string FormStringFromIndexes(string content, string firstGroup, string secondGroup)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(' ', 100);
            int[] firstIndexes = new int[firstGroup.Length];
            int[] secondIndexes = new int[secondGroup.Length];
            for (int i = 0; i < firstGroup.Length; i++)
            {
                firstIndexes[i] = int.Parse(firstGroup[i].ToString());
            }
            for (int i = 0; i < secondGroup.Length; i++)
            {
                secondIndexes[i] = int.Parse(secondGroup[i].ToString());
            }

            for (int j = 0; j < firstIndexes.Length; j++)
            {

                if (content.Length > firstIndexes[j])
                {
                    stringBuilder.Append(content[firstIndexes[j]]);
                }
            }
            for (int j = 0; j < secondIndexes.Length; j++)
            {
                if (content.Length > secondIndexes[j])
                {
                    stringBuilder.Append(content[secondIndexes[j]]);
                }
            }
            string result = stringBuilder.ToString().Trim();

            return result;
        }
    }
}
