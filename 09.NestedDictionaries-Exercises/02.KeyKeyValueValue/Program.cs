using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.KeyKeyValueValue
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyToSearch = Console.ReadLine();
            string valueToSearch = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(new string[] {" => "}, StringSplitOptions.RemoveEmptyEntries);

                string key = tokens[0];
                string[] values = tokens[1].Split(';');

                if (key.Contains(keyToSearch))
                {
                    Console.WriteLine($"{key}:");
                    for (int j = 0; j < values.Length; j++)
                    {
                        if (values[j].Contains(valueToSearch))
                        {
                            Console.WriteLine($"-{values[j]}");
                        }
                    }
                }
                
            }
        }
    }
}
