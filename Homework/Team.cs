using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Team
    {
        private ICollection<FootballPlayer> players;

        public Team(Coach coach, ICollection<FootballPlayer> inputPlayers)
        {
            this.Coach = coach;
            this.Players = inputPlayers;
        }

        public Coach Coach { get; private set; }
        public ICollection<FootballPlayer> Players
        {
            get => players;
            private  set
            {
                if (value.Count < 11 || value.Count > 22)
                {
                    throw new ArgumentOutOfRangeException("Players count must be between 11 and 22");
                }
               players = value;
                
            }
        }


        public int AveragePlayersAge
            => (int)players.Average(x => x.Age);

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Choach: ");
            sb.AppendLine($"  Name: {this.Coach.Name} ");
            sb.AppendLine($"  Age: {this.Coach.Age} ");

            sb.AppendLine($"Team: ");
            sb.AppendLine($"  Average players age: {this.AveragePlayersAge}");
            sb.AppendLine($"  Names: {string.Join(", ", this.Players.Select(x => x.Name))}");

            return sb.ToString().TrimEnd();
        }
    }
}
