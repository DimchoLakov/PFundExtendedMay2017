using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LargestElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int biggestElement = int.MinValue; 
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                int currentElemnt = arr[i];
                if (currentElemnt > biggestElement)
                {
                    biggestElement = currentElemnt;
                }
            }
            Console.WriteLine(biggestElement);
        }
    }
}
