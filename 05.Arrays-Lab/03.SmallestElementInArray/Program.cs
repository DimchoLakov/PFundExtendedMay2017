using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SmallestElementInArray
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int[] myArr = new int[input.Length];
            int smallestNumber = int.MaxValue;

            for (int i = 0; i < input.Length; i++)
            {                
                myArr[i] = int.Parse(input[i]);
                int currentNumber = myArr[i];
                if (currentNumber < smallestNumber)
                {
                    smallestNumber = currentNumber;
                }
            }
            Console.WriteLine(smallestNumber);
        }
    }
}
