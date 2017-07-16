using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RegisteredUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, DateTime> users = new Dictionary<string, DateTime>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(new string[] {" -> "}, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                string date = tokens[1];

                DateTime realDate = DateTime.ParseExact(date, string.Format("dd/MM/yyyy"), CultureInfo.InvariantCulture);

                if (!users.ContainsKey(name))
                {
                    users[name] = realDate;
                }
                
                input = Console.ReadLine();
            }

            Dictionary<string, DateTime> result = new Dictionary<string, DateTime>();

            users = users.Reverse().OrderBy(x => x.Value).ToDictionary(pair => pair.Key, pair => pair.Value);

            int count = 0;

            foreach (KeyValuePair<string, DateTime> nameAndDate in users)
            {
                if (count >= 5)
                {
                    break;
                }
                count++;
                result.Add(nameAndDate.Key, nameAndDate.Value);
            }

            foreach (KeyValuePair<string, DateTime> namesDates in result.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{namesDates.Key}");
            }
        }
    }
}
