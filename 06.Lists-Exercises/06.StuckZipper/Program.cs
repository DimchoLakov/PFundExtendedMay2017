using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StuckZipper
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> result = new List<int>();

            int firstSmallestDigit = int.MaxValue;
            int secondSmallestDigit = int.MaxValue;

            for (int i = 0; i < firstList.Count; i++)
            {
                int currentNumber = Math.Abs(firstList[i]);
                currentNumber = currentNumber.ToString().Length;
                if (currentNumber < firstSmallestDigit)
                {
                    firstSmallestDigit = currentNumber;
                }
            }

            for (int i = 0; i < secondList.Count; i++)
            {
                int currentNumber = Math.Abs(secondList[i]);
                currentNumber = currentNumber.ToString().Length;
                if (currentNumber < secondSmallestDigit)
                {
                    secondSmallestDigit = currentNumber;
                }
            }

            int realSmallestDigit = Math.Min(firstSmallestDigit, secondSmallestDigit);

            for (int i = 0; i < firstList.Count; i++)
            {
                int currentNumber = Math.Abs(firstList[i]);
                currentNumber = currentNumber.ToString().Length;
                if (currentNumber > realSmallestDigit)
                {
                    firstList.Remove(firstList[i]);
                    i--;
                }
            }

            for (int i = 0; i < secondList.Count; i++)
            {
                int currentNumber = Math.Abs(secondList[i]);
                currentNumber = currentNumber.ToString().Length;
                if (currentNumber > realSmallestDigit)
                {
                    secondList.Remove(secondList[i]);
                    i--;
                }
            }

            int shorterList = Math.Min(firstList.Count, secondList.Count);

            for (int i = 0; i < shorterList; i++)
            {
                result.Add(secondList[i]);
                result.Add(firstList[i]);
            }

            if (firstList.Count > secondList.Count)
            {
                for (int i = shorterList; i < firstList.Count; i++)
                {
                    result.Add(firstList[i]);
                }
            }
            else
            {
                for (int i = shorterList; i < secondList.Count; i++)
                {
                    result.Add(secondList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
