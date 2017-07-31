using System;

namespace _06.SentenceSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            string delimiter = Console.ReadLine();

            inputText = inputText.Replace(delimiter, ", ");
            Console.WriteLine($"[{inputText}]");
        }
    }
}
