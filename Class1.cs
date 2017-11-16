using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class GameClass
    {
            public string team1 { get; set; }
            public string team2 { get; set; }
            public int team1Score { get; set; }
            public int team2Score { get; set; }

            public GameClass() { }

            public GameClass(string team1, int team1Score, string team2, int team2Score)
            {
                this.team1 = team1;
                this.team2 = team2;
                this.team1Score = team1Score;
                this.team2Score = team2Score;
            }
    }
}


