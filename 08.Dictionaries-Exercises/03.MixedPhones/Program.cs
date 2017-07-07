using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MixedPhones
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> phonebook = new Dictionary<string, long>();

            string input = Console.ReadLine();

            string[] tokens = input.Split(new char[] { ' ', ':'},StringSplitOptions.RemoveEmptyEntries);

            while (input != "Over")
            {
                string firstElement = tokens[0];
                string secondElement = tokens[1];
                
                long secondElementPhone;

                if (long.TryParse(secondElement, out secondElementPhone))
                {
                    if (!phonebook.ContainsKey(firstElement))
                    {
                        phonebook.Add(firstElement, secondElementPhone);
                    }
                    else
                    {
                        phonebook[firstElement] = secondElementPhone;
                    }
                }
                else
                {
                    if (!phonebook.ContainsKey(secondElement))
                    {
                        phonebook.Add(secondElement, long.Parse(firstElement));
                    }
                    else
                    {
                        phonebook[secondElement] = long.Parse(firstElement);
                    }
                }


                input = Console.ReadLine();

                tokens = input.Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (KeyValuePair<string, long> contact in phonebook.OrderBy(name => name.Key))
            {
                Console.WriteLine($"{contact.Key} -> {contact.Value}");
            }

        }
    }
}
