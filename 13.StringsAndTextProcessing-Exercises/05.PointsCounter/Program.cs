using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.PointsCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> teamDict = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "Result")
            {
                string[] tokens = input.Split('|');

                string firstToken = RemoveBannedChars(tokens[0]);
                string secondToken = RemoveBannedChars(tokens[1]);
                string playerName = string.Empty;
                string teamName = string.Empty;

                bool IsTeam = CheckTeamOrPlayer(firstToken);
                if (IsTeam)
                {
                    teamName = firstToken;
                    playerName = secondToken;
                }
                else
                {
                    teamName = secondToken;
                    playerName = firstToken;
                }

                int points = int.Parse(tokens[2]);

                if (!teamDict.ContainsKey(teamName))
                {
                    teamDict.Add(teamName, new Dictionary<string, int>());
                }
                if (!teamDict[teamName].ContainsKey(playerName))
                {
                    teamDict[teamName].Add(playerName, 0);
                }
                teamDict[teamName][playerName] = points;


                input = Console.ReadLine();
            }

            var result = teamDict.OrderByDescending(x => x.Value.Values.Sum())
                .ThenByDescending(p => p.Value.Values.Max());

            foreach (KeyValuePair<string, Dictionary<string, int>> team in result)
            {
                string bestPlayer = team.Value.OrderByDescending(x => x.Value).First().Key;
                int totalPoints = teamDict.Where(t => t.Key == team.Key).Sum(s => s.Value.Values.Sum());
                Console.WriteLine($"{team.Key} => {totalPoints}");
                Console.WriteLine($"Most points scored by {bestPlayer}");
            }
        }

        public static bool CheckTeamOrPlayer(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsUpper(input[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public static string RemoveBannedChars(string names)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < names.Length; i++)
            {
                if (char.IsLetter(names[i]))
                {
                    sb.Append(names[i]);
                }
            }
            return sb.ToString();
        }
    }
}
