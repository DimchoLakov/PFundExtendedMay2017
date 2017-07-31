using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.JSONStringify
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int[] Grades { get; set; }

        public static Student ParseStudent(string name, int age, int[] grades)
        {
            Student newStudent = new Student
            {
                Name = name,
                Age = age,
                Grades = grades
            };
            return newStudent;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();

            string input = Console.ReadLine();

            while (input != "stringify")
            {
                string[] tokens = input.Split(new Char[] {' ', ',', '-', '>', ':'}, StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];

                int age = int.Parse(tokens[1]);

                int[] grades = tokens.Skip(2).Select(int.Parse).ToArray();

                studentList.Add(Student.ParseStudent(name, age, grades));

                input = Console.ReadLine();
            }

            StringBuilder result = new StringBuilder();

            result.Append("[");

            foreach (Student student in studentList)
            {
                result.Append(
                    $"{{name:\"{student.Name}\",age:{student.Age},grades:[{string.Join(", ", student.Grades)}]}},");
            }
            result.Remove(result.Length - 1, 1);
            result.Append("]");
            Console.WriteLine(result.ToString());
        }
    }
}
