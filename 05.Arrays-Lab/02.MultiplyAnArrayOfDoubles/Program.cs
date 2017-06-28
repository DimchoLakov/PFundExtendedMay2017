using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MultiplyAnArrayOfDoubles
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();

            double p = double.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * p;
                Console.Write(arr[i] + " ");
            }
        }
    }
}
