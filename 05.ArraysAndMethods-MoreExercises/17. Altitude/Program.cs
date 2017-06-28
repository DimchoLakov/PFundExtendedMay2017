using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Altitude
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries );

            long startAltitude = int.Parse(input[0]);
            

            string[] commands = new string[input.Length / 2];
            long[] values = new long[input.Length / 2];
            long commandsIndex = 0;
            long valuesIndex = 0;

            for (long i = 1; i < input.Length; i++)
            {
                if (i % 2 != 0)
                {
                    commands[commandsIndex] = input[i];
                    commandsIndex++;
                }
                else
                {
                    values[valuesIndex] = long.Parse(input[i]);
                    valuesIndex++;
                }               
            }

            for (long i = 0; i < commands.Length; i++)
            {
                if (commands[i] == "up")
                {
                    startAltitude += values[i];
                }
                else if (commands[i] == "down")
                {
                    startAltitude -= values[i];
                }
                if (startAltitude <= 0)
                {
                    Console.WriteLine("crashed");
                    return;
                }
            }

            Console.WriteLine($"got through safely. current altitude: {startAltitude}m");
        }
    }
}
