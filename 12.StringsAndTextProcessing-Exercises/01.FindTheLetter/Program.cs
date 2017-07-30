using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FindTheLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            string[] letterAndOccurences = Console.ReadLine().Split(' ');
            char wantedLetter = char.Parse(letterAndOccurences[0]);
            int wantedLetterOccurences = int.Parse(letterAndOccurences[1]);

            char[] arr = inputText.ToCharArray();
            int count = 0;
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == wantedLetter)
                {
                    count++;
                    if (count == wantedLetterOccurences)
                    {
                        index = i;
                    }
                }
            }
            if (index != -1)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine($"Find the letter yourself!");
            }
            
        }
    }
}
