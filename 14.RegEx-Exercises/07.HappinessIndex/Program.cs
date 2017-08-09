using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _07.HappinessIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] happyEmoticons = ":), :D, ;), :*, :], ;], :}, ;}, (:, *:, c:, [:, [;"
                .Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

            string[] sadEmoticons = ":(, D:, ;(, :[, ;[, :{, ;{, ):, :c, ]:, ];"
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            string happyPattern = @"(\:\)|\:D|\;\)|\:\*|\:\]|\;\]|\:\}|\;\}|\(\:|\*\:|c\:|\[\:|\[\;)";
            string sadPattern = @"(\:\(|D\:|\;\(|\:\[|\;\[|\:\{|\;\{|\)\:|\:c|\]\:|\]\;)";

            string input = Console.ReadLine();

            Regex happyRegex = new Regex(happyPattern);
            Regex sadRegex = new Regex(sadPattern);

            MatchCollection happyMatches = happyRegex.Matches(input);
            MatchCollection sadMatches = sadRegex.Matches(input);

            double happyCount = 0d;
            double sadCount = 0d;

            foreach (Match happyMatch in happyMatches)
            {
                if (happyEmoticons.Contains(happyMatch.Value))
                {
                    happyCount++;
                }
            }

            foreach (Match sadMatch in sadMatches)
            {
                if (sadEmoticons.Contains(sadMatch.Value))
                {
                    sadCount++;
                }
            }

            double happinessIndex = happyCount / sadCount;
            string mood = string.Empty;

            if (happinessIndex >= 2)
            {
                mood = ":D";
            }
            else if (happinessIndex > 1)
            {
                mood = ":)";
            }
            else if (happinessIndex == 1)
            {
                mood = ":|";
            }
            else if (happinessIndex < 1)
            {
                mood = ":(";
            }

            Console.WriteLine($"Happiness index: {happinessIndex:f2} {mood}");
            Console.WriteLine($"[Happy count: {happyCount}, Sad count: {sadCount}]");
        }
    }
}
