using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PowerPlants
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] plants = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int daysSurvived = 0;
            int season = 0;
            int power = 0;

            while (true)
            {
                for (int i = 0; i < plants.Length; i++)
                {
                    power = 0;
                    daysSurvived++;

                    for (int j = 0; j < plants.Length; j++)
                    {
                        if (i == j)
                        {
                            if (plants[i] > 0)
                            {
                                plants[i]++;
                            }
                        }

                        if (plants[j] > 0)
                        {
                            plants[j]--;
                        }

                        power += plants[j];
                    }

                    if (power > 0) continue;
                    else break;

                }

                if (power > 0)
                {
                    season++;

                    for (int i = 0; i < plants.Length; i++)
                    {
                        if (plants[i] > 0)
                        {
                            plants[i]++;
                        }
                    }
                }

                else break;

            }

            if (season == 1)
            {
                Console.WriteLine($"survived {daysSurvived} days ({season} season)");
            }
            else
            {
                Console.WriteLine($"survived {daysSurvived} days ({season} seasons)");
            }
        }
    }
}
