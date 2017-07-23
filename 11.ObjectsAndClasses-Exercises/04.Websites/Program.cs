using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Websites
{
    class Website
    {
        public string Host { get; set; }
        public string Domain { get; set; }
        public List<string> Queries { get; set; }
        public Website(string host, string domain, List<string> queries)
        {
            Host = host;
            Domain = domain;
            Queries = queries;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Website> websitesData = new List<Website>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

                string hostName = tokens[0];
                string domainName = tokens[1];

                List<string> queries = new List<string>();

                if (tokens.Length > 2)
                {
                    queries = tokens[2].Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries).ToList();
                }

                websitesData.Add(new Website(hostName, domainName, queries));

                input = Console.ReadLine();
            }

            foreach (Website website in websitesData)
            {
                if (website.Queries.Count > 0)
                {
                    Console.WriteLine($"https://www.{website.Host}.{website.Domain}/query?=[{string.Join("]&[", website.Queries)}]");
                }
                else
                {
                    Console.WriteLine($"https://www.{website.Host}.{website.Domain}");
                }
            }

        }
    }
}
