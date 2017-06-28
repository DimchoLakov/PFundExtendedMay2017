using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.EqualSequenceOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool areEqual = true;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int currentElement = arr[i];
                int nextElement = arr[i + 1];

                if (currentElement != nextElement)
                {
                    areEqual = false;
                    break;
                }
            }

            if (areEqual)
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
