using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.NumbersToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(Lettersize(number));
            }

        }

        static string Lettersize(int number)
        {
            string result = string.Empty;
            string[] hundreds = { "one-hundred", "two-hundred", "three-hundred", "four-hundred", "five-hundred",
                "six-hundred", "seven-hundred", "eight-hundred", "nine-hundred" };
            string[] oneToNine = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", };
            string[] tens = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] elevenToNineteen = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen",
                "seventeen", "eighteen" };

            if (number > 999)
            {
                Console.WriteLine("too large");
                return null;
            }
            else if (number < -999)
            {
                Console.WriteLine("too small");
                return null;
            }

            int checkDigits = CheckHowManyDigitsNumberHave(number);

            if (checkDigits == 3 && number == 100 || number == 200 || number == 300 || number == 400 || number == 500
                 || number == 600 || number == 700 || number == 800 || number == 900)
            {
                result = hundreds[number / 100 - 1];
                return result;
            }
            else if (checkDigits == 3 && number == -100 || number == -200 || number == -300 || number == -400 || number == -500
                 || number == -600 || number == -700 || number == -800 || number == -900)
            {
                result = "minus " + hundreds[Math.Abs(number) / 100 - 1];
                return result;
            }

            int firstDigit = number % 10;
            int decreaseNumber = number / 10;
            int secondDigit = decreaseNumber;
            secondDigit = secondDigit % 10;
            int decreaseNumberAgain = decreaseNumber / 10;
            int thirdDigit = decreaseNumberAgain;

            if (firstDigit > 0 && firstDigit < 10 && secondDigit == 0)
            {
                result = hundreds[number % 10 - 1] + " and " + oneToNine[number % 10 - 1];
                return result;
            }
            else if (secondDigit > 1 && secondDigit < 10 && firstDigit == 0)
            {
                result = hundreds[number / 100 - 1] + " and " + tens[number / 100 - 2];
            }


            return result;
        }

        static int CheckHowManyDigitsNumberHave(int number)
        {
            int counter = 0;

            while (number != 0)
            {
                number /= 10;
                counter++;
            }

            return counter;
        }
    }
}
