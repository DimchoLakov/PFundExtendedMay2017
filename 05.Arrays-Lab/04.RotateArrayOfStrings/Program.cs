using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.RotateArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myArr = Console.ReadLine().Split();
            string lastElement = myArr[myArr.Length - 1];

            for (int i = myArr.Length - 1; i > 0; i--)
            {
                myArr[i] = myArr[i - 1];
            }
            myArr[0] = lastElement;

            for (int i = 0; i < myArr.Length; i++)
            {
                Console.Write(myArr[i] + " ");
            }
        }
    }
}
