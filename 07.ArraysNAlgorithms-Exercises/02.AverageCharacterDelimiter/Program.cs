using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AverageCharacterDelimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();
            double sum = 0d;
            double counter = 0d;

            for (int i = 0; i < arr.Length; i++)
            {
                char[] textToChar = arr[i].ToCharArray();
                for (int j = 0; j < textToChar.Length; j++)
                {
                    sum += textToChar[j];
                    counter++;
                }
            }
            int result = (int)Math.Truncate(sum / counter);
            string letter = ((char)result).ToString().ToUpper();
            Console.WriteLine(string.Join($"{letter}", arr));
        }
    }
}
