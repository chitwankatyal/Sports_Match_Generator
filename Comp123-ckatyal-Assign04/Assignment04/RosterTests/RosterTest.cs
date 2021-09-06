using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment03;
using System.Collections.Generic;
using System.Linq;

namespace RosterTests
{
    [TestClass]
    public class RosterTest
    {
        [TestMethod]
        public void RosterTest_CompareResults_Success()
        {
            //Assign
            List<Team> teams = new List<Team>();

            Team teamFirst = new Team("Team One")
            {
                Roster = new List<Player>()
                {
                    new Player()
                }
            };
            Team teamSecond = new Team("Team Two")
            {
                Roster = new List<Player>()
                {
                    new Player()
                }
            };
            Team teamThird = new Team("Team Three")
            {
                Roster = new List<Player>()
                {
                    new Player()
                }
            };
            Team teamFourth = new Team("Team Four");

            teamFirst.TeamId = 1;
            teamSecond.TeamId = 2;
            teamThird.TeamId = 3;
            teamFourth.TeamId = 4;

            //Act
            teams.Add(teamFirst);
            teams.Add(teamSecond);
            teams.Add(teamThird);
            teams.Add(teamFourth);

            MatchupRepository matchupRepository = new MatchupRepository();
            matchupRepository.GenerateSeason(teams);

            List<Matchup> matchups = new List<Matchup>();
            matchups = matchupRepository.Matchups;

            //Assert
            foreach (Matchup matchup in matchups)
            {
                Assert.IsTrue(matchups.Where(m => m.HomeTeam.Roster.Count() == 0).Count() == 0);
                Assert.IsTrue(matchups.Where(m => m.AwayTeam.Roster.Count() == 0).Count() == 0);
            }
        }
    }
}
//Assert.IsTrue(matchup.HomeTeam.Roster.Count > 0);
//Assert.IsTrue(matchup.AwayTeam.Roster.Count > 0);
