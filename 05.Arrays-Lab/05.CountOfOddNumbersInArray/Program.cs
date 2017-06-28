using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CountOfOddNumbersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int oddCounter = 0;

            for (int i = 0; i < myArr.Length; i++)
            {
                if (myArr[i] % 2 != 0)
                {
                    oddCounter++;
                }
            }
            Console.WriteLine(oddCounter);            
        }
    }
}
