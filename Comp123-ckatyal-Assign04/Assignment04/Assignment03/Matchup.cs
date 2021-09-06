using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    public class Matchup
    {
        public static int NextId = 1;
        public int Matchupid { get; set; }
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }

        public Matchup()
        {

        }
        public Matchup(Team homeTeam, Team awayTeam)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            Matchupid = NextId++;
        }
    }
}
