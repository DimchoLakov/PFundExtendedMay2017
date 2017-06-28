using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Notifications
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (input == "success")
                {
                    string operation = Console.ReadLine();
                    string message = Console.ReadLine();
                    ShowSuccess(operation, message);
                }
                else if (input == "error")
                {
                    string operation = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());
                    ShowError(operation, code);
                }
                else
                {
                    continue;
                }
            }

            
        }

        static string ShowSuccess(string operation, string message)
        {
            Console.WriteLine($"Successfully executed {operation}.");
            Console.WriteLine($"==============================");
            Console.WriteLine($"Message: {message}.");
            return null;
        }

        static string ShowError(string operation, int code)
        {
            Console.WriteLine($"Error: Failed to execute {operation}.");
            Console.WriteLine($"==============================");
            Console.WriteLine($"Error Code: {code}.");
            if (code > 0 )
            {
                Console.WriteLine($"Reason: Invalid Client Data.");
            }
            else
            {
                Console.WriteLine($"Reason: Internal System Failure.");
            }

            return null;
        }
    }
}
