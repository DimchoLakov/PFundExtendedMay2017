using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RabbitHole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> obstacles = Console.ReadLine().Split(' ').ToList();
            int energy = int.Parse(Console.ReadLine());
            int position = 0;
            bool isBombed = false;

            while (true)
            {
                string[] tokens = obstacles[position].Split('|');
                switch (tokens[0])
                {
                    case "Right":
                        position = (position + int.Parse(tokens[1])) % obstacles.Count;
                        energy -= int.Parse(tokens[1]);
                        break;
                    case "Left":
                        position = Math.Abs(position - int.Parse(tokens[1])) % obstacles.Count;
                        energy -= int.Parse(tokens[1]);
                        break;
                    case "Bomb":
                        energy -= int.Parse(tokens[1]);
                        obstacles.RemoveAt(position);
                        position = 0;
                        isBombed = true;
                        break;
                    case "RabbitHole":
                        Console.WriteLine($"You have 5 years to save Kennedy!");
                        return;
                }

                if (energy <= 0)
                {
                    if (isBombed)
                    {
                        Console.WriteLine($"You are dead due to bomb explosion!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You are tired. You can't continue the mission.");
                        break;
                    }
                }

                if (obstacles[obstacles.Count - 1] != "RabbitHole")
                {
                    obstacles.RemoveAt(obstacles.Count - 1);
                }

                obstacles.Add("Bomb|" + energy);

            }

        }
    }
}
