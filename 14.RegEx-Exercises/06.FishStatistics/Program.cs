using System;
using System.Text.RegularExpressions;

namespace _06.FishStatistics
{
    class Program
    {
        static void Main(string[] args)
        {

            Regex fishPattern = new Regex(@">*<\(+['\-x]>");

            string input = Console.ReadLine();

            MatchCollection fishMatches = fishPattern.Matches(input);
            int fishCount = 1;
            foreach (Match fishMatch in fishMatches)
            {
                int tailLength = 0;
                int bodyLength = 0;
                string status = string.Empty;
                foreach (char ch in fishMatch.Value)
                {
                    switch (ch)
                    {
                        case '>':
                            tailLength++;
                            break;
                        case '(':
                            bodyLength++;
                            break;
                        case '\'':
                            status = "Awake";
                            break;
                        case 'x':
                            status = "Dead";
                            break;
                        case '-':
                            status = "Asleep";
                            break;
                    }
                }
                tailLength--;
                string tailType = GetTailType(tailLength);
                string bodyType = GetBodyType(bodyLength);
                
                Console.WriteLine($"Fish {fishCount}: {fishMatch.Value}");
                Console.WriteLine(tailLength > 0
                    ? $"  Tail type: {tailType} ({tailLength * 2} cm)"
                    : $"  Tail type: {tailType}");
                Console.WriteLine($"  Body type: {bodyType} ({bodyLength * 2} cm)");
                Console.WriteLine($"  Status: {status}");
                fishCount++;
            }
            if (fishCount == 1)
            {
                Console.WriteLine($"No fish found.");
            }
        }

        static string GetBodyType(int bodyLength)
        {
            if (bodyLength > 10)
            {
                return "Long";
            }
            else if (bodyLength > 5)
            {
                return "Medium";
            }
            else
            {
                return "Short";
            }
        }

        static string GetTailType(int tailLength)
        {
            if (tailLength > 5)
            {
                return "Long";
            }
            else if (tailLength > 1)
            {
                return "Medium";
            }
            else if (tailLength == 1)
            {
                return "Short";
            }
            else
            {
                return "None";
            }
        }
    }
}
