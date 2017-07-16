using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUniBeerPong
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, double>> teams = new Dictionary<string, Dictionary<string, double>>();

            while (input != "stop the game")
            {
                string[] tokens = input.Split('|');
                string playerName = tokens[0];
                string teamName = tokens[1];
                double points = double.Parse(tokens[2]);

                if (!teams.ContainsKey(teamName))
                {
                    teams.Add(teamName, new Dictionary<string, double>());
                }

                if (teams[teamName].Count < 3)
                {
                    if (!teams[teamName].ContainsKey(playerName))
                    {
                        teams[teamName].Add(playerName, points);
                    }
                }


                input = Console.ReadLine();
            }

            int count = 1;

            foreach (KeyValuePair<string, Dictionary<string, double>> team in teams.OrderByDescending(x => x.Value.Values.Sum()))
            {
                if (team.Value.Count == 3)
                {
                    Console.WriteLine($"{count}. {team.Key}; Players:");
                    foreach (KeyValuePair<string, double> player in team.Value.OrderByDescending(x => x.Value))
                    {
                        Console.WriteLine($"###{player.Key}: {player.Value}");
                    }
                    count++;
                }
                
            }
        }
    }
}
