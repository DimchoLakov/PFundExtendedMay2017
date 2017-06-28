using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.StringEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string encryption = string.Empty;
            for (int i = 0; i < n; i++)
            {
                char myChar = char.Parse(Console.ReadLine());
                encryption += Encrypt(myChar);
            }
            Console.WriteLine(encryption);
        }

        static string Encrypt(char myChar)
        {
            int asciiNumber = (int)myChar;
            var asciiArr = asciiNumber.ToString().ToCharArray();
            char firstItem = asciiArr[0];
            char lastItem = asciiArr[asciiArr.Length - 1];
            string firstItemToString = firstItem.ToString();
            string lastItemToString = lastItem.ToString();
            char start = (char)(asciiNumber + int.Parse(lastItemToString));
            char end = (char)(asciiNumber - int.Parse(firstItemToString));
            string result = start + firstItemToString + lastItemToString + end;

            return result;
        }
    }
}
