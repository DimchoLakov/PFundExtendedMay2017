using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.JSONParse
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            input = input.Substring(2, input.Length - 2 - 2);

            string[] tokens = input.Split(new String[] {"},{"}, StringSplitOptions.RemoveEmptyEntries);

            foreach (string token in tokens)
            {
                string[] props = token.Split(new string[] {",age:", ",grades:"}, StringSplitOptions.RemoveEmptyEntries);

                string name = props[0].Substring(6, props[0].Length - 6 - 1);
                int age = int.Parse(props[1]);
                string grades = props[2].Substring(1, props[2].Length - 1 - 1);
                if (grades == string.Empty)
                {
                    grades = "None";
                }
                Console.WriteLine($"{name} : {age} -> {grades}");
            }
        }
    }
}
