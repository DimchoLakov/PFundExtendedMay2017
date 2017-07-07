using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FilterBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> ageDict = new Dictionary<string, int>();
            Dictionary<string, double> salaryDict = new Dictionary<string, double>();
            Dictionary<string, string> positionDict = new Dictionary<string, string>();

            string input = Console.ReadLine();

            string[] tokens = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            while (input != "filter base")
            {
                string name = tokens[0];
                string secondHalf = tokens[1];
                
                double salary;
                int age;

                if (int.TryParse(secondHalf, out age))
                {
                    if (!ageDict.ContainsKey(name))
                    {
                        ageDict.Add(name, age);
                    }
                    else
                    {
                        ageDict[name] = age;
                    }
                }
                else if (double.TryParse(secondHalf, out salary))
                {
                    if (!salaryDict.ContainsKey(name))
                    {
                        salaryDict.Add(name, salary);
                    }
                    else
                    {
                        salaryDict[name] = salary;
                    }
                }
                else
                {
                    if (!positionDict.ContainsKey(name))
                    {
                        positionDict.Add(name, secondHalf);
                    }
                    else
                    {
                        positionDict[name] = secondHalf;
                    }
                }

                input = Console.ReadLine();
                tokens = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            }

            input = Console.ReadLine();

            switch (input)
            {
                case "Age":
                    foreach (KeyValuePair<string, int> nameAgePair in ageDict)
                    {
                        Console.WriteLine($"Name: {nameAgePair.Key}");
                        Console.WriteLine($"Age: {nameAgePair.Value}");
                        Console.WriteLine(new string('=', 20));
                    }
                    break;
                case "Salary":
                    foreach (KeyValuePair<string, double> nameSalaryPair in salaryDict)
                    {
                        Console.WriteLine($"Name: {nameSalaryPair.Key}");
                        Console.WriteLine($"Salary: {nameSalaryPair.Value:f2}");
                        Console.WriteLine(new string('=', 20));
                    }
                    break;
                case "Position":
                    foreach (KeyValuePair<string, string> namePositionPair in positionDict)
                    {
                        Console.WriteLine($"Name: {namePositionPair.Key}");
                        Console.WriteLine($"Position: {namePositionPair.Value}");
                        Console.WriteLine(new string('=', 20));
                    }
                    break;
            }
        }
    }
}
