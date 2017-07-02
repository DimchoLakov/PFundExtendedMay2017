using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DecodeRadioFrequencies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ').ToArray();
            List<char> list = new List<char>();

            for (int i = 0; i < numbers.Length; i++)
            {
                string[] splittedNumber = numbers[i].Split('.');
                int firstNumber = int.Parse(splittedNumber[0]);
                int secondNumber = int.Parse(splittedNumber[1]);
                char firstChar = (char)firstNumber;
                char secondChar = (char)secondNumber;

                if (firstNumber != 0)
                {
                    list.Insert(i, firstChar);
                }
                if (secondChar != 0)
                {
                    list.Insert(list.Count - 1 - i, secondChar);
                }
                
            }
            list.Reverse();
            Console.WriteLine(string.Join("", list));
        }
    }
}
