using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Camel_is_back
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int camelBackSize = int.Parse(Console.ReadLine());

            int count = (list.Count - camelBackSize) / 2;

            if (list.Count > camelBackSize)
            {
                list.RemoveRange(0, count);
                list.RemoveRange(camelBackSize, count);
                Console.WriteLine($"{count} rounds");
                Console.WriteLine("remaining: " + string.Join(" ", list));
            }
            else if (list.Count == camelBackSize)
            {
                Console.WriteLine("already stable: " + string.Join(" ", list));
            }

        }
    }
}
