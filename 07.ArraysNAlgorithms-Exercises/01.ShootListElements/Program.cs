using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ShootListElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> list = new List<int>();
            int shotNumber = 0;

            while (input != "stop")
            {
                int number;
                if (int.TryParse(input, out number))
                {
                    list.Insert(0, number);
                }
                else if (input == "bang")
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {shotNumber}");
                        return;
                    }
                    else if (list.Count == 1)
                    {
                        shotNumber = list[0];
                        list.Remove(list[0]);
                        Console.WriteLine($"shot {shotNumber}");
                        input = Console.ReadLine();
                        continue;
                    }
                    double average = list.Average();
                    bool remove = false;
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] < average)
                        {
                            shotNumber = list[i];
                            list.Remove(shotNumber);
                            remove = true;
                            Console.WriteLine($"shot {shotNumber}");
                            for (int j = 0; j < list.Count; j++)
                            {
                                list[j]--;
                            }
                            if (remove)
                            {
                                break;
                            }
                        }                        
                    }                           
                }

                input = Console.ReadLine();
            }
            if (list.Count > 0)
            {
                Console.WriteLine("survivors: " + string.Join(" ", list));
            }
            else
            {
                Console.WriteLine($"you shot them all. last one was {shotNumber}");
            }

        }
    }
}
