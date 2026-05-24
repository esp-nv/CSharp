
using Ex05.FootballTeamGenerator.Common;

namespace Ex05.FootballTeamGenerator.Models
{
    public class Team
    {
        private string name;
        private List<Player> players;
        
        public Team() 
        {
            players = new List<Player>();
        }

        public Team(string name)
            : this() 
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
               return this.name; 
            }
           private set
            {

                if (String.IsNullOrWhiteSpace(value))
                { 
                    throw new ArgumentException(GlobalConstants.EmptyNameExceptionMessage);
                }

                this.name = value;
            } 
        }

        public int Rating
        {
            get
            {
                if(this.players.Count == 0)
                {
                    return 0;
                }

               return (int)Math.Round(this.players.Sum(p => p.OverallSkill) / this.players.Count());
            }
        }
        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RemovePlayer(string name)
        {
            Player playerToRemove= this.players.FirstOrDefault(p => p.Name == name);


            //ако няма никой е с !
            if (playerToRemove == null)
            {
                
                string excMsg = String.Format(GlobalConstants.RemovingMissingNameExceptionMessage, name, this.Name);

                throw new InvalidOperationException(excMsg);
            }

            this.players.Remove(playerToRemove);
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Rating}";
            ;
        }
        
    }
}
