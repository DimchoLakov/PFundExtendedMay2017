using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.IncreasingSequenceOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool isIncreasingSequence = true;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int currentElement = arr[i];
                int nextElement = arr[i + 1];
                if (currentElement > nextElement)
                {
                    isIncreasingSequence = false;
                    break;
                }
            }

            if (isIncreasingSequence)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
