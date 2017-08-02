using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.DiamondProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool hasFoundDiamond = false;
            int startIndex = -1;
            int endIndex = -1;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '<')
                {
                    startIndex = i;
                }
                if (input[i] == '>')
                {
                    endIndex = i;
                }
                if (startIndex < endIndex && startIndex != -1)
                {
                    int carats = CalculateCarats(input, startIndex, endIndex);
                    PrintDiamonds(carats);
                    startIndex = -1;
                    endIndex = -1;
                    hasFoundDiamond = true;
                }
            }
            if (!hasFoundDiamond)
            {
                Console.WriteLine($"Better luck next time");
            }
        }

        private static void PrintDiamonds(int carats)
        {
            Console.WriteLine($"Found {carats} carat diamond");
        }

        public static int CalculateCarats(string input, int startIndex, int endIndex)
        {
            int sum = 0;
            for (int i = startIndex + 1; i < endIndex; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    sum += int.Parse(input[i].ToString());
                }
            }
            return sum;
        }
    }
}
