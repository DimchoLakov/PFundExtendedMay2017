using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.CountOfGivenElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int searchNumber = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentNumber = arr[i];
                if (currentNumber == searchNumber)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
