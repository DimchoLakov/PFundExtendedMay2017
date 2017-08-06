using System;
using System.Collections.Generic;
using System.Text;

namespace _08.Nilapdromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            while (input != "end")
            {
                string nilapdrome = GetNilapdrome(input);
                if (!string.IsNullOrEmpty(nilapdrome))
                {
                    Console.WriteLine(nilapdrome);
                }

                input = Console.ReadLine();
            }
            
        }

        public static string GetNilapdrome(string input)
        {
            int middleIndex = input.Length / 2;
            string border = string.Empty;
            int leftIndex = 0;

            for (int i = middleIndex + 1; i < input.Length; i++)
            {
                if (input[leftIndex] == input[i])
                {
                    border += input[i];
                    leftIndex++;
                }
                else
                {
                    border = string.Empty;
                    leftIndex = 0;
                    if (input[i] == input[leftIndex])
                    {
                        border += input[i];
                        leftIndex++;
                    }
                }
            }
            
            string middleContent = string.Empty;
            if (border != string.Empty)
            {
                int leftIndexMiddle = input.IndexOf(border);
                int rightIndexMiddle = input.LastIndexOf(border);

                middleContent = input.Substring(leftIndexMiddle + border.Length,
                    rightIndexMiddle - leftIndexMiddle - border.Length);
                if (middleContent != string.Empty)
                {
                    return middleContent + border + middleContent;
                }
            }

            return null;
        }
    }
}
