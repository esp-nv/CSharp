
using Ex05.FootballTeamGenerator.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05.FootballTeamGenerator.Models
{
    public class Player
    {
        private string name;

        //в конструктора мога да сетвам пропъртита, където нямат сетари, но само там никъде другаде
        public Player(string name, Stats stats)
        {
            this.Name = name;
            this.Stats = stats;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.EmptyNameExceptionMessage);
                }
                this.name = value;
            }
        }

        public Stats Stats { get; }

        public double OverallSkill =>

            this.Stats.AvaregeStats;
        
    }
}
