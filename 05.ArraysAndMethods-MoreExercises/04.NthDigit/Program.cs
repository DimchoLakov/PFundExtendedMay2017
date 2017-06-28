using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NthDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int indexN = int.Parse(Console.ReadLine());

            int nThDigit = FindNthDigits(number, indexN);
            Console.WriteLine(nThDigit);
        }

        static int FindNthDigits(int number, int indexN)
        {
            int currentIndex = 1;

            while (number != 0)
            {
                if (currentIndex == indexN)
                {
                    return number % 10;
                }
                else
                {
                    number /= 10;
                }

                currentIndex++;
            }
            return number % 10;
            
        }
    }
}
