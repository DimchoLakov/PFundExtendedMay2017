using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > 0)
                {
                    result.Add(list[i]);
                }
            }
            result.Reverse();
            if (result.Count > 0)
            {
                Console.WriteLine(string.Join(" ", result));
            }
            else 
            {
                Console.WriteLine("empty");
            }
        }
    }
}
