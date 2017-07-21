using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _03.BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger bigFactorial = 1;

            for (int i = n; i > 0; i--)
            {
                bigFactorial *= i;
            }
            Console.WriteLine(bigFactorial);

        }
    }
}
