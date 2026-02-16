using System;
using System.Collections.Generic;
using System.Linq;


namespace _01.Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            var contests = new Dictionary<string, Dictionary<string, int>>();
            var users = new Dictionary<string, Dictionary<string, int>>();
            while ((input = Console.ReadLine()) != "end of contests")
            {
                var tokens = input.Split(':', StringSplitOptions.RemoveEmptyEntries);
                var contestName = tokens[0];
                var password = tokens[1];
                if (!contests.ContainsKey(contestName))
                {
                    contests[contestName] = new Dictionary<string, int>();
                }
                contests[contestName][password] = 0; // Initialize with 0 points
            }
            while ((input = Console.ReadLine()) != "end of submissions")
            {
                var tokens = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                var contestName = tokens[0];
                var password = tokens[1];
                var username = tokens[2];
                var points = int.Parse(tokens[3]);
                if (contests.ContainsKey(contestName) && contests[contestName].ContainsKey(password))
                {
                    if (!users.ContainsKey(username))
                    {
                        users[username] = new Dictionary<string, int>();
                    }
                    if (!users[username].ContainsKey(contestName) || users[username][contestName] < points)
                    {
                        users[username][contestName] = points;
                    }
                }
            }
            var bestUser = users.OrderByDescending(u => u.Value.Values.Sum()).FirstOrDefault();
            Console.WriteLine("Best candidate is " + bestUser.Key + " with total " + bestUser.Value.Values.Sum() + " points.");
            Console.WriteLine("Ranking:");
            foreach (var user in users.OrderBy(u => u.Key))
            {
                Console.WriteLine(user.Key);
                foreach (var contest in user.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
