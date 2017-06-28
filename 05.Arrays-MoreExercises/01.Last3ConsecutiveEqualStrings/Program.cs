using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Last3ConsecutiveEqualStrings
{
    class Program
    {
        static void Main()
        {
            var myArr = Console.ReadLine().Split(' ').ToArray();
            var result = new string[3];
            int counter = 1;
            for (int i = myArr.Length - 1; i > 0; i--)
            {
                if (myArr[i] == myArr[i - 1])
                {
                    counter++;
                    if (counter == 3)
                    {
                        for (int k = 0; k < counter; k++)
                        {
                            result[k] = myArr[i];
                        }
                        Console.WriteLine(string.Join(" ", result));
                        break;
                    }
                }
                else
                {
                    counter = 1;
                }
            }
        }        
    }
}
