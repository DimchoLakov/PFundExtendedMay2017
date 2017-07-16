using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _07.SocialMediaPosts
{
    class Program
    {
        static void Main(string[] args)
        {
            var database = new Dictionary<string, Dictionary<string, List<string>>>();


            string input = Console.ReadLine();

            while (input != "drop the media")
            {
                string[] tokens = input.Split(' ');

                string action = tokens[0];
                string postName = tokens[1];

                switch (action)
                {
                    case "post":
                        if (!database.ContainsKey(action))
                        {
                            database.Add(postName, new Dictionary<string, List<string>>());
                            database[postName].Add("Likes", new List<string>());
                            database[postName].Add("Dislikes", new List<string>());
                            database[postName].Add("Comments", new List<string>());
                        }
                        break;
                    case "like":

                        if (database.ContainsKey(postName))
                        {
                            database[postName]["Likes"].Add("like");
                        }

                        break;
                    case "dislike":
                        if (database.ContainsKey(postName))
                        {
                            database[postName]["Dislikes"].Add("dislike");
                        }

                        break;
                    case "comment":
                        {
                            string name = tokens[2];

                            List<string> comment = tokens.Skip(3).Take(tokens.Length).ToList();

                            string result = string.Join(" ", comment);

                            string commentToAdd = $"*  {name}: {result}";

                            if (database.ContainsKey(postName))
                            {
                                database[postName]["Comments"].Add(commentToAdd);
                            }
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Dictionary<string, List<string>>> postPair in database)
            {
                int likes = postPair.Value["Likes"].Count;
                int dislikes = postPair.Value["Dislikes"].Count;
                int commentsCount = postPair.Value["Comments"].Count;
                string allComments = string.Join($"{Environment.NewLine}", postPair.Value["Comments"].ToList());

                Console.WriteLine($"Post: {postPair.Key} | Likes: {likes} | Dislikes: {dislikes}");
                Console.WriteLine("Comments:");

                if (commentsCount > 0)
                {
                    Console.WriteLine($"{allComments}");
                }
                else
                {
                    Console.WriteLine("None");
                }
                
            }

        }
    }
}