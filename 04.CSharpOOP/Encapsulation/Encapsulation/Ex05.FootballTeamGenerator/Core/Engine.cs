using Ex05.FootballTeamGenerator.Common;
using Ex05.FootballTeamGenerator.Models;

namespace Ex05.FootballTeamGenerator.Core
{
    public class Engine
    {
        private List<Team> teams;

        public Engine()
        {
            this.teams = new List<Team>();
        }

        public void Run()
        {
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                try
                {
                    string[] cmdArg = command.Split(";", StringSplitOptions.None).ToArray();

                    string cmdType = cmdArg[0];

                    if (cmdType == "Team")
                    {
                        AddTeam(cmdArg);
                    }
                    else if (cmdType == "Add")
                    {
                        AddPlayerToTeam(cmdArg);

                    }
                    else if (cmdType == "Remove")
                    {
                        RemovePlayer(cmdArg);

                    }
                    else if (cmdType == "Rating")
                    {
                        PrintRating(cmdArg);

                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);                
                    
                }
                catch(InvalidOperationException ioe)
                {                  
                    Console.WriteLine(ioe.Message);                 
                }

            }
        }

        private void PrintRating(string[] cmdArg)
        {
            string teamName = cmdArg[1];

            this.ValidateTeamExists(teamName);
            Team team = this.teams.First(t => t.Name == teamName);
            Console.WriteLine(team);
        }

        private void RemovePlayer(string[] cmdArg)
        {
            string teamName = cmdArg[1];
            string playerName = cmdArg[2];

            this.ValidateTeamExists(teamName);
            Team team = this.teams.First(t => t.Name == teamName);

            team.RemovePlayer(playerName);
        }

        private void AddPlayerToTeam(string[] cmdArg)
        {
            string teamName = cmdArg[1];
            string playerName = cmdArg[2];

            this.ValidateTeamExists(teamName);
            Team team = this.teams.First(t => t.Name == teamName);

            Stats stats = this.CreateStats(cmdArg.Skip(3).ToArray());
            Player player = new Player(playerName, stats);

            team.AddPlayer(player);
        }

        private Stats CreateStats(string[] cmdArgs)
        {
            int endurance = int.Parse(cmdArgs[0]);
            int sprint = int.Parse(cmdArgs[1]);
            int dribble = int.Parse(cmdArgs[2]);
            int passing = int.Parse(cmdArgs[3]);
            int shooting = int.Parse(cmdArgs[4]);

            Stats stats = new Stats(endurance, sprint, dribble, passing, shooting);

            return stats;
        }

        private void ValidateTeamExists(string name)
        {
            if (!this.teams.Any(t => t.Name == name))
            {
                string excMsg = String.Format(GlobalConstants.MissingTeamExceptionMessage, name);

                throw new ArgumentException(excMsg);
            }

        }

        private void AddTeam(string[] cmdArg)
        {
            string teamName = cmdArg[1];
            Team team = new Team(teamName);
            teams.Add(team);
        }
    }
}
