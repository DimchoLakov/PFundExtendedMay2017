using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SerializeString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            foreach (char c in input.Distinct())
            {
                List<int> result = new List<int>();
                int index = input.IndexOf(c);
                result.Add(index);
                while (index != -1)
                {
                    index = input.IndexOf(c, index + 1);
                    if (index != -1)
                    {
                        result.Add(index);
                    }
                }
                Console.WriteLine($"{c}:{string.Join("/", result)}");
            }
        }
    }
}
