using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').ToArray();
            var names = Console.ReadLine().Split(' ').ToArray();

            string input = Console.ReadLine();

            while (input != "done")
            {
                var searchIndex = Array.IndexOf(names, input);

                Console.WriteLine($"{input} -> {numbers[searchIndex]}");               

                input = Console.ReadLine();
            }
        }
    }
}
