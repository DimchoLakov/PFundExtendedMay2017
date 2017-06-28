using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MinMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int minAOrB = GetMin(a, b);
            Console.WriteLine(GetMin(minAOrB, c));

        }

        static int GetMin(int a, int b)
        {
            int min = Math.Min(a, b);
            return min;
        }
    }
}
