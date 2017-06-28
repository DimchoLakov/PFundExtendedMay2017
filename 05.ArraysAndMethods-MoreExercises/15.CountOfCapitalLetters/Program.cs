using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.CountOfCapitalLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrStr = Console.ReadLine().Split();
            int count = 0;

            for (int i = 0; i < arrStr.Length; i++)
            {
                string currentElement = arrStr[i];

                if (currentElement == currentElement.ToUpper())
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
