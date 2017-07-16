using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace _01.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string name = input[0];
                double grade = double.Parse(input[1]);

                if (!studentGrades.ContainsKey(name))
                {
                    studentGrades.Add(name, new List<double>());
                }

                studentGrades[name].Add(grade);

            }

            foreach (var student in studentGrades)
            {
                List<double> gradesList = student.Value;
                double average = gradesList.Average();

                Console.WriteLine(
                    $"{student.Key} -> {string.Join(" ", gradesList.Select(gr => string.Format("{0:f2}", gr)))} (avg: {average:f2})");
            }

        }
    }
}
