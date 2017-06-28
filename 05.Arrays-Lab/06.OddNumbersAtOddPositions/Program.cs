using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.OddNumbersAtOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < myArr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    if (myArr[i] % 2 != 0)
                    {
                        Console.WriteLine($"Index {i} -> {myArr[i]}");
                    }
                }
            }
        }
    }
}
