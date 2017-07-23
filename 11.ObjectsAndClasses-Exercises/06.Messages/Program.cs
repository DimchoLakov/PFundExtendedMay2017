using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace _06.Messages
{
    class User
    {
        public string Username { get; set; }
        public List<Message> ReceivedMessages { get; set; }

        public User(string username)
        {
            Username = username;
            ReceivedMessages = new List<Message>();
        }
    }

    class Message
    {
        public string Content { get; set; }
        public User Sender { get; set; }

        public Message(string content, User sender)
        {
            Content = content;
            Sender = sender;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, User> users = new Dictionary<string, User>();

            string input = Console.ReadLine();

            while (input != "exit")
            {
                string[] tokens = input.Split(' ');

                if (tokens[0] == "register")
                {
                    string username = tokens[1];
                    users.Add(username, new User(username));
                }
                else
                {
                    string sender = tokens[0];
                    string recipient = tokens[2];
                    string content = tokens[3];

                    if (users.ContainsKey(sender) && users.ContainsKey(recipient))
                    {
                        User senderUser = users[sender];
                        users[recipient].ReceivedMessages.Add(new Message(content, senderUser));
                    }

                }
                input = Console.ReadLine();
            }

            string[] chatTokens = Console.ReadLine().Split(' ');

            string chatSender = chatTokens[0];
            string chatRecipient = chatTokens[1];

            List<Message> senderMessages = users[chatRecipient].ReceivedMessages
                .Where(m => m.Sender.Username == chatSender).ToList();

            List<Message> recipientMessages = users[chatSender].ReceivedMessages
                .Where(m => m.Sender.Username == chatRecipient).ToList();

            if (senderMessages.Count == 0 && recipientMessages.Count == 0)
            {
                Console.WriteLine($"No messages");
                return;
            }

            int index = 0;

            while (index < senderMessages.Count && index < recipientMessages.Count)
            {
                Console.WriteLine($"{chatSender}: {senderMessages[index].Content}");
                Console.WriteLine($"{recipientMessages[index].Content} :{chatRecipient}");

                index++;
            }

            while (index < senderMessages.Count)
            {
                Console.WriteLine($"{chatSender}: {senderMessages[index].Content}");
                index++;
            }
            while (index < recipientMessages.Count)
            {
                Console.WriteLine($"{recipientMessages[index].Content} :{chatRecipient}");
                index++;
            }
        }
    }
}
