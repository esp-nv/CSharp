using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TeamworkProjects
{
    internal class Program
    {
        public class Team
        {
            public string Name { get; set; }
            public string Creator { get; set; }
            public List<string> Members { get; set; }
            public Team(string name, string creator)
            {
                Name = name;
                Creator = creator;
                Members = new List<string>();
            }
            public override string ToString()
            {
                return $"{Name}\n" +
                  $"- {Creator}\n" +
                  $"{GetMembersString()}";
            }
            private string GetMembersString()
            {
                if (Members.Count == 0)
                    return "";

                Members = Members.OrderBy(name => name).ToList();

                return string.Join("\n", Members.Select(m => $"-- {m}"));

            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            List<string> creators = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string[] teamParts = Console.ReadLine().Split("-");
                string creator = teamParts[0];
                string teamName = teamParts[1];
                if (creators.Contains(creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }
                if (teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                Team team = new Team(teamName, creator);
                teams.Add(team);
                creators.Add(creator);
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }
            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] commandParts = command.Split("->");
                string member = commandParts[0];
                string teamName = commandParts[1];
                if (!teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }
                if (creators.Contains(member) || teams.Any(t => t.Members.Contains(member)))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                    continue;
                }
                var team = teams.First(t => t.Name == teamName);
                team.Members.Add(member);
            }

            foreach (var team in teams .Where(t => t.Members.Count > 0).OrderByDescending(t => t.Members.Count).ThenBy(t => t.Name))
            {
                Console.WriteLine(team);
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in teams.Where(t => t.Members.Count == 0).OrderBy(t => t.Name))
            {
                Console.WriteLine(team.Name);
            }

        }
    }
}
