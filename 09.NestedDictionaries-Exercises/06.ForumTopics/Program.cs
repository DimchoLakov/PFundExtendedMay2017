using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ForumTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            Dictionary<string, HashSet<string>> webInfo = new Dictionary<string, HashSet<string>>();

            while (input != "filter")
            {
                string[] tokens = input.Split(new string[] { " -> "}, StringSplitOptions.RemoveEmptyEntries);

                string topic = tokens[0];

                string[] tags = tokens[1].Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

                if (! webInfo.ContainsKey(topic))
                {
                    webInfo.Add(topic, new HashSet<string>());
                }

                foreach (string tag in tags)
                {
                    webInfo[topic].Add(tag);
                }

                input = Console.ReadLine();
            }

            string secondInput = Console.ReadLine();
            string[] afterFilter = secondInput.Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

            foreach (KeyValuePair<string, HashSet<string>> topicTag in webInfo)
            {
                bool doesContains = false;
                for (int i = 0; i < afterFilter.Length; i++)
                {

                    if (topicTag.Value.Contains(afterFilter[i]))
                    {
                        doesContains = true;
                    }
                    else
                    {
                        doesContains = false;
                        break;
                    }

                }

                if (doesContains)
                {
                    Console.WriteLine($"{topicTag.Key} | #{string.Join(", #", topicTag.Value)}");
                }

            }
        }
    }
}
