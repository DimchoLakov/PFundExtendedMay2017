using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.OrderedBankingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, decimal>> bank = new Dictionary<string, Dictionary<string, decimal>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(new char[] {' ', '-', '>'}, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                string account = tokens[1];
                decimal balance = decimal.Parse(tokens[2]);

                if (! bank.ContainsKey(name))
                {
                    bank.Add(name, new Dictionary<string, decimal>());
                }

                if (! bank[name].ContainsKey(account))
                {
                    bank[name].Add(account, balance);
                }
                else
                {
                    bank[name][account] += balance;
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Dictionary<string, decimal>> bankAccount in bank.OrderByDescending(m => m.Value.Values.Sum()).ThenByDescending(d => d.Value.Max(balance => balance.Value)))
            {
                foreach (var acc in bankAccount.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{acc.Key} -> {acc.Value} ({bankAccount.Key})");
                }
            }

        }
    }
}
