using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.IntegerInsertion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string input = Console.ReadLine();
            if (input == "end")
            {
                return;
            }
            while (input != "end")
            {
                int number = int.Parse(input);
                char[] arr = number.ToString().ToCharArray();
                int index = int.Parse(arr[0].ToString());

                list.Insert(index, number);

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
