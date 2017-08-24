using System;

namespace _01.DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPairDigits = int.Parse(Console.ReadLine());
            int secondPairDigits = int.Parse(Console.ReadLine());
            int thirdPairDigits = int.Parse(Console.ReadLine());
            int fourthPairDigits = int.Parse(Console.ReadLine());

            string result = $"{firstPairDigits:D4} {secondPairDigits:D4} {thirdPairDigits:D4} {fourthPairDigits:D4}";
            Console.WriteLine(result);
        }
    }
}
