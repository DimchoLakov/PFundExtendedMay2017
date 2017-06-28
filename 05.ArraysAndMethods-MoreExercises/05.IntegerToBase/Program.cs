using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.IntegerToBase
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            Console.WriteLine(IntToBase(number, toBase));
        }

        static string IntToBase(int number, int toBase)
        {
            string result = string.Empty;
            int currentIndex = 0;
            while (number != 0)
            {
                int remainder = number % toBase;
                result += remainder;
                number /= toBase;
                currentIndex++;
            }
            var reversed = result.ToArray().Reverse();
            result = string.Join("", reversed);
            return result;
        }
    }
}
