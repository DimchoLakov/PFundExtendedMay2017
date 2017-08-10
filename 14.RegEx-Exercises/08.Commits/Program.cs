using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text.RegularExpressions;

namespace _08.Commits
{
    class Commit
    {
        public string Hash { get; set; }
        public string Message { get; set; }
        public int Additions { get; set; }
        public int Deletions { get; set; }

        public static Commit ParseCommit(string hash, string message, int additions, int deletions)
        {
            return new Commit
            {
                Hash = hash,
                Message = message,
                Additions = additions,
                Deletions = deletions
            };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, Dictionary<string, List<Commit>>> github = new Dictionary<string, Dictionary<string, List<Commit>>>();

            string gitPattern =
                @"https:\/\/github\.com\/(?<user>[A-Za-z\d-]+)\/(?<repo>[A-Za-z-_]+)\/commit\/(?<hash>[a-f\d]{40}),(?<message>[^\n]+),(?<additions>\d+),(?<deletions>\d+)";

            while (input != "git push")
            {
                Regex gitRegex = new Regex(gitPattern);
                Match gitMatch = gitRegex.Match(input);

                if (!gitRegex.IsMatch(input))
                {
                    input = Console.ReadLine();
                    continue;
                }

                string username = gitMatch.Groups["user"].ToString();
                string repo = gitMatch.Groups["repo"].ToString();
                string hash = gitMatch.Groups["hash"].ToString();
                string message = gitMatch.Groups["message"].ToString();
                int additions = int.Parse(gitMatch.Groups["additions"].ToString());
                int deletions = int.Parse(gitMatch.Groups["deletions"].ToString());

                if (! github.ContainsKey(username))
                {
                    github.Add(username, new Dictionary<string, List<Commit>>());;
                }
                if (! github[username].ContainsKey(repo))
                {
                    github[username].Add(repo, new List<Commit>());
                }
                github[username][repo].Add(Commit.ParseCommit(hash, message, additions, deletions));

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Dictionary<string, List<Commit>>> userRepoPair in github.OrderBy(name => name.Key))
            {
                string user = userRepoPair.Key;
                Console.WriteLine($"{user}:");
                foreach (KeyValuePair<string, List<Commit>> repoCommitPair in userRepoPair.Value.OrderBy(rep => rep.Key))
                {
                    string repo = repoCommitPair.Key;
                    List<Commit> commits = repoCommitPair.Value;
                    Console.WriteLine($"  {repo}:");
                    foreach (Commit commit in commits)
                    {
                        Console.WriteLine($"    commit {commit.Hash}: {commit.Message} ({commit.Additions} additions, {commit.Deletions} deletions)");
                    }
                    int totalAdditions = commits.Sum(a => a.Additions);
                    int totalDeletions = commits.Sum(a => a.Deletions);
                    Console.WriteLine($"Total: {totalAdditions} additions, {totalDeletions} deletions");
                }
            }
        }
    }
}
