using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _18.BalisticsTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] aimCoordinates = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();

            BigInteger aimX = aimCoordinates[0];
            BigInteger aimY = aimCoordinates[1];

            string[] input = Console.ReadLine().Split(' ');

            string command;
            BigInteger commandValue;

            BigInteger targetX = 0;
            BigInteger targetY = 0;

            for (int i = 0; i < input.Length - 1; i += 2)
            {
                command = input[i];
                commandValue = BigInteger.Parse(input[i + 1]);

                switch (command)
                {
                    case "up":
                        targetY += commandValue;
                        break;
                    case "down":
                        targetY -= commandValue;
                        break;
                    case "left":
                        targetX -= commandValue;
                        break;
                    case "right":
                        targetX += commandValue;
                        break;
                }
            }
            if (targetX == aimX && targetY == aimY)
            {
                Console.WriteLine($"firing at [{targetX}, {targetY}]\ngot 'em!");
                return;
            }
            Console.WriteLine($"firing at [{targetX}, {targetY}]\nbetter luck next time...");

        }
    }
}
