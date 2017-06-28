using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.EqualSumAfterExtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < firstList.Count; i++)
            {
                for (int j = 0; j < secondList.Count; j++)
                {
                    if (firstList[i] == secondList[j])
                    {
                        secondList.Remove(firstList[i]);
                    }
                }
            }

            int sumOne = firstList.Sum();
            int sumTwo = secondList.Sum();

            if (sumOne == sumTwo)
            {
                Console.WriteLine($"Yes. Sum: {sumOne}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(sumOne - sumTwo)}");
            }

        }
    }
}
