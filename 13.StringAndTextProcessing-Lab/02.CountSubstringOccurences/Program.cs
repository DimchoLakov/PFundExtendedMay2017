using System;

namespace _02.CountSubstringOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string givenText = Console.ReadLine().ToLower();
            string wantedString = Console.ReadLine().ToLower();
            
            int index = givenText.IndexOf(wantedString);
            int occurences = 0;

            while (index != -1)
            {
                index = givenText.IndexOf(wantedString, index + 1);
                occurences++;
            }
            Console.WriteLine(occurences);
        }
    }
}
