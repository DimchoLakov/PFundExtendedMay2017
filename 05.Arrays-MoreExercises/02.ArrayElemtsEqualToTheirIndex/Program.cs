using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ArrayElemtsEqualToTheirIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            var myArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < myArr.Length; i++)
            {
                int currentNumber = myArr[i];
                int index = i;
                if (currentNumber == index)
                {
                    Console.Write($"{currentNumber} ");
                }
            }
        }
    }
}
