using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03.Animals
{
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfLegs { get; set; }

        public static Dog ParseDog(string dogName, int dogAge, int dogLegs)
        {
            Dog newDog = new Dog
            {
                Name = dogName,
                Age = dogAge,
                NumberOfLegs = dogLegs
            };
            return newDog;
        }
        public void ProduceSound()
        {
            Console.WriteLine($"I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
        }
    }

    class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int IntelligenceQuotient { get; set; }

        public static Cat ParseCat(string catName, int catAge, int catIntelligence)
        {
            Cat newCat = new Cat
            {
                Name = catName,
                Age = catAge,
                IntelligenceQuotient = catIntelligence
            };
            return newCat;
        }
        public void ProduceSound()
        {
            Console.WriteLine($"I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
        }

    }

    class Snake
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int CrueltyCoefficient { get; set; }

        public static Snake ParseSnake(string snakeName, int snakeAge, int snakeCruelty)
        {
            Snake newSnake = new Snake
            {
                Name = snakeName,
                Age = snakeAge,
                CrueltyCoefficient = snakeCruelty
            };
            return newSnake;
        }

        public void ProduceSound()
        {
            Console.WriteLine($"I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dog> dogDict = new Dictionary<string, Dog>();
            Dictionary<string, Cat> catDict = new Dictionary<string, Cat>();
            Dictionary<string, Snake> snakeDict = new Dictionary<string, Snake>();

            string input = Console.ReadLine();

            while (input != "I'm your Huckleberry")
            {
                string[] tokens = input.Split(' ');

                if (tokens.Length == 4)
                {
                    string className = tokens[0];
                    string animalName = tokens[1];
                    int animalAge = int.Parse(tokens[2]);
                    int animalFeature = int.Parse(tokens[3]);

                    switch (className)
                    {
                        case "Dog":
                            Dog puppy = Dog.ParseDog(animalName, animalAge, animalFeature);
                            dogDict.Add(animalName, puppy);
                            break;
                        case "Cat":
                            Cat kitty = Cat.ParseCat(animalName, animalAge, animalFeature);
                            catDict.Add(animalName, kitty);
                            break;
                        case "Snake":
                            Snake snakey = Snake.ParseSnake(animalName, animalAge,animalFeature);
                            snakeDict.Add(animalName, snakey);
                            break;
                    }

                }
                else if (tokens.Length == 2)
                {
                    string animalToTalk = tokens[1];
                    if (dogDict.ContainsKey(animalToTalk))
                    {
                        dogDict[animalToTalk].ProduceSound();
                    }
                    else if (catDict.ContainsKey(animalToTalk))
                    {
                        catDict[animalToTalk].ProduceSound();
                    }
                    else if (snakeDict.ContainsKey(animalToTalk))
                    {
                        snakeDict[animalToTalk].ProduceSound();
                    }
                }

                input = Console.ReadLine();
            }

            foreach (Dog dog in dogDict.Values)
            {
                Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.NumberOfLegs}");
            }

            foreach (Cat cat in catDict.Values)
            {
                Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.IntelligenceQuotient}");
            }

            foreach (Snake snake in snakeDict.Values)
            {
                Console.WriteLine($"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.CrueltyCoefficient}");
            }

        }
    }
}
