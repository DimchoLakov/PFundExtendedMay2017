using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CountOfNegativeElementsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int countNegatives = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                int currentElement = arr[i];

                if (currentElement < 0)
                {
                    countNegatives++;
                }
            }
            Console.WriteLine(countNegatives);
        }
    }
}
