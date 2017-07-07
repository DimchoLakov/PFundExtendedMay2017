using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.UserLogins
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> userList = new Dictionary<string, string>();

            int attemptsCounter = 0;

            AddUsers(userList);

            LogInUsers(userList, ref attemptsCounter);

            Console.WriteLine($"unsuccessful login attempts: {attemptsCounter}");
        }

        static void LogInUsers(Dictionary<string, string> userList ,ref int counter)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            while (input != "end")
            {
                string username = tokens[0];
                string password = tokens[1];

                bool isValidUsername = userList.ContainsKey(username);
                bool isValidPassword = userList.ContainsValue(password);

                if (!isValidUsername || !isValidPassword || !(isValidUsername && isValidPassword))
                {
                    Console.WriteLine($"{username}: login failed");
                    counter++;
                }
                else
                {
                    Console.WriteLine($"{username}: logged in successfully");
                }



                input = Console.ReadLine();
                tokens = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

        }

        static void AddUsers(Dictionary<string, string> userList)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            while (input != "login")
            {
                string username = tokens[0];
                string password = tokens[1];

                if (!userList.ContainsKey(username))
                {
                    userList.Add(username, password);
                }
                else
                {
                    userList[username] = password;
                }



                input = Console.ReadLine();
                tokens = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

        }
    }
}
