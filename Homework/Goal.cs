using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Goal
    {
        public Goal(double minute, FootballPlayer playerScoredTheGoal)
        {
            Minute = minute;
            PlayerScoredTheGoal = playerScoredTheGoal;
        }

        public double Minute { get; set; }
        public FootballPlayer PlayerScoredTheGoal { get; set; }

    }
}
