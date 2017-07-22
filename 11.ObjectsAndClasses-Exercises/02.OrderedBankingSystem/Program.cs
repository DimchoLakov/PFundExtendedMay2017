using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OrderedBankingSystem
{
    class BankAccount
    {
        public string Name { get; set; }
        public string Bank { get; set; }
        public decimal Balance { get; set; }

        public static BankAccount Parse(string personName, string bankName, decimal money)
        {
            BankAccount bankAcc = new BankAccount
            {
                Name = personName,
                Bank = bankName,
                Balance = money
            };
            return bankAcc;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> listBankAccounts = new List<BankAccount>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(new string[] {" | "}, StringSplitOptions.RemoveEmptyEntries);

                string bank = tokens[0];
                string name = tokens[1];
                decimal balance = decimal.Parse(tokens[2]);
                BankAccount newBankAccount = BankAccount.Parse(name, bank, balance);

                listBankAccounts.Add(newBankAccount);

                input = Console.ReadLine();
            }

            foreach (BankAccount bankAcc in listBankAccounts.OrderByDescending(bal => bal.Balance).ThenBy(bankName => bankName.Bank.Length))
            {
                Console.WriteLine($"{bankAcc.Name} -> {bankAcc.Balance} ({bankAcc.Bank})");
            }

        }
    }
}
