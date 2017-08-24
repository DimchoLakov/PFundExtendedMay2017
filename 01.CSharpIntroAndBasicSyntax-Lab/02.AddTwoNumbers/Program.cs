using System;

namespace _02.AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int result = firstNumber + secondNumber;
            Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");
        }
    }
}
