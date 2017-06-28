using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.StringRepeater
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string result = RepeatString(input, n);
            Console.WriteLine(result);

        }

        static string RepeatString(string input, int n)
        {
            string repeatedString = string.Empty;
            for (int i = 0; i < n; i++)
            {
                repeatedString += input;
            }
            return repeatedString;
        }
    }
}
