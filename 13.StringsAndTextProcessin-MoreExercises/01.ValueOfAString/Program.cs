using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ValueOfAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();
            double sum = 0d;

            if (command == "UPPERCASE")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsUpper(input[i]))
                    {
                        sum += input[i];
                    }
                }
            }
            else if (command == "LOWERCASE")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsLower(input[i]))
                    {
                        sum += input[i];
                    }
                }
            }
            Console.WriteLine($"The total sum is: {sum}");
        }
    }
}
