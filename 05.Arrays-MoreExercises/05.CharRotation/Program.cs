using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CharRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charArr = Console.ReadLine().ToCharArray();
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                var symbol = (int)charArr[i];
                var number = nums[i];
                if (number % 2 == 0)
                {
                    symbol -= number;
                    charArr[i] = (char)symbol;
                }
                else
                {
                    symbol += number;
                    charArr[i] = (char)symbol;
                }
            }

            Console.WriteLine(charArr);
        }
    }
}
