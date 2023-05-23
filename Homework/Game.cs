using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Game
    {
        private ICollection<Goal> scoredGoals;

        private Team team1;
        private Team team2;

        public Game(Team team1, Team team2, Referee referee, Referee assistantReferee_1, Referee assistantReferee_2, ICollection<Goal> goalss, string gameResult, string winner)
        {
            this.Team1 = team1;
            this.Team2 = team2;
            this.Referee = referee;
            this.AssistantReferee_1 = assistantReferee_1;
            this.AssistantReferee_2 = assistantReferee_2;
            this.scoredGoals = goalss;
            this.GameResult = gameResult;
            this.Winner = winner;
        }

        public Team Team1
        {
            get => team1;
            private set
            {
                if (value.Players.Count != 11)
                {
                    throw new ArgumentOutOfRangeException("Players count must be exact 11!");
                }
                team1 = value;
            }
        }
        public Team Team2
        {
            get => team2;
            private set
            {
                if (value.Players.Count != 11)
                {
                    throw new ArgumentOutOfRangeException("Players count must be exact 11!");
                }
                team2 = value;
            }
        }
        public Referee Referee { get; set; }
        public Referee AssistantReferee_1 { get; set; }
        public Referee AssistantReferee_2 { get; set; }

        public string GameResult { get; set; }
        public string Winner { get; set; }

        // Variant with nested class --> 
        // public class Goal
        // {
        //     public Goal(double minute, FootballPlayer playerScoredTheGoal)
        //     {
        //         Minute = minute;
        //         PlayerScoredTheGoal = playerScoredTheGoal;
        //     }

        //     public double Minute { get; set; }
        //     public FootballPlayer PlayerScoredTheGoal { get; set; }
        // }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Team 1:");
            sb.AppendLine(this.Team1.ToString());
            sb.AppendLine("----- // -----");
            sb.AppendLine("Team 2:");
            sb.AppendLine(this.Team2.ToString());
            sb.AppendLine("----- // -----");
            sb.AppendLine("Match Results: ");
            sb.AppendLine($"Referee: {this.Referee.Name}");
            sb.AppendLine($"Assistant Referee 1: {this.AssistantReferee_1.Name}");
            sb.AppendLine($"Assistant Referee 2: {this.AssistantReferee_2.Name}");
            sb.AppendLine($"Goals: ");
            foreach (var sg in this.scoredGoals)
            {
                sb.AppendLine($"-- Goal time: {sg.Minute}");
                sb.AppendLine($"-- Scorer: {sg.PlayerScoredTheGoal.Name}");
            }
            sb.AppendLine($"Game result: {GameResult}");
            sb.AppendLine($"Winner: {Winner}");

            return sb.ToString().TrimEnd();
        }

    }
}
