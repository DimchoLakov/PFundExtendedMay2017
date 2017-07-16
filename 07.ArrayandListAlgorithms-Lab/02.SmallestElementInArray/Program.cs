using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SmallestElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int smallestElement = int.MaxValue;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < smallestElement)
                {
                    smallestElement = list[i];
                }
            }
            Console.WriteLine(smallestElement);
        }
    }
}
