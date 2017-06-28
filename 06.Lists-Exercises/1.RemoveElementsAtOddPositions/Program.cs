using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.RemoveElementsAtOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();
            string result = string.Empty;
            for (int i = 1; i < list.Count; i++)
            {
                if (i % 2 != 0)
                {
                    result += list[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
