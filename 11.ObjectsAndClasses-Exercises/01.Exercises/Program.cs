using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Exercises
{
    class Exercise
    {
        public string Topic { get; set; }
        public string CourseName { get; set; }
        public string JudgeContestLink { get; set; }

        public List<string> Problems { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Exercise> exercises = new List<Exercise>();

            while (input != "go go go")
            {
                Exercise newExercise = new Exercise();

                string[] tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                newExercise.Topic = tokens[0];
                newExercise.CourseName = tokens[1];
                newExercise.JudgeContestLink = tokens[2];

                string[] problems = tokens[3].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                newExercise.Problems = new List<string>();

                foreach (string problem in problems)
                {
                    newExercise.Problems.Add(problem);
                }
                exercises.Add(newExercise);

                input = Console.ReadLine();
            }


            foreach (Exercise exercise in exercises)
            {
                Console.WriteLine($"Exercises: {exercise.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{exercise.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {exercise.JudgeContestLink}");
                int counter = 1;
                foreach (string problem in exercise.Problems)
                {
                    Console.WriteLine($"{counter}. {problem}");
                    counter++;
                }
            }
        }
    }
}
