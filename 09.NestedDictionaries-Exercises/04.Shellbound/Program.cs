using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _04.Shellbound
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<BigInteger>> shellbound = new Dictionary<string, List<BigInteger>>();

            string input = Console.ReadLine();

            while (input != "Aggregate")
            {
                string[] tokens = input.Split(' ');

                string region = tokens[0];
                BigInteger shellSize = BigInteger.Parse(tokens[1]);

                if (!shellbound.ContainsKey(region))
                {
                    shellbound.Add(region, new List<BigInteger>());
                    shellbound[region].Add(shellSize);
                }
                else
                {
                    shellbound[region].Add(shellSize);
                }
                
                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string,List<BigInteger>> regionAndShells in shellbound)
            {
                List<BigInteger> shells = regionAndShells.Value.Distinct().ToList();
                
                BigInteger sum = 0;

                for (int i = 0; i < shells.Count; i++)
                {
                    sum += shells[i];
                }
                BigInteger average = sum / shells.Count;

                Console.WriteLine($"{regionAndShells.Key} -> {string.Join(", ",shells)} ({sum - average})");

            }
            
        }
    }
}
