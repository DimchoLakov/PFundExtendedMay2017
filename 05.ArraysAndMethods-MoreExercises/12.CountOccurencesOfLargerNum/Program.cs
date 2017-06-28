using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CountOccurencesOfLargerNum
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double num = double.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                double currentNumber = arr[i];

                if (currentNumber > num)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
