using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment03;
using System.Collections.Generic;
using System.Linq;

namespace SeasonTests
{
    [TestClass]
    public class SeasonTest
    {
        [TestMethod]
        public void SeasonTest_CompareResults_Success()
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
            Team teamFourth = new Team("Team Four")
            {
                Roster = new List<Player>()
                {
                    new Player()
                }
            };

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
            foreach  (Team team in teams)
            {
                // for HomeTeam
                Assert.IsTrue(matchups.Where(m => m.HomeTeam.TeamId == team.TeamId).Count() == teams.Count() - 1);

                // for AwayTeam
                Assert.IsTrue(matchups.Where(m => m.AwayTeam.TeamId == team.TeamId).Count() == teams.Count() - 1);
                
            }
        }
    }
}
            //teamFirst.TeamId = 1;
            //teamSecond.TeamId = 2;
            //teamThird.TeamId = 3;
            //teamFourth.TeamId = 4;

            //List<Matchup> homeTeams = new List<Matchup>();
            //List<Matchup> awayTeams = new List<Matchup>();
            //List<Team> homeTeamOpponents = new List<Team>();
            //List<Team> awayTeamOpponents = new List<Team>();

            //foreach (Team team in teams)
            //{
            //    foreach (Matchup matchup in matchups)
            //    {
            //        if (team.TeamId == matchup.HomeTeam.TeamId)
            //        {
            //            homeTeams.Add(matchup);
            //        }
            //        if (team.TeamId == matchup.AwayTeam.TeamId)
            //        {
            //            awayTeams.Add(matchup);
            //        }
            //    }

            //    var expectedValHome = teams.Count - 1;
            //    var originalValHome = homeTeams.Count;
            //    var expectedValAway = teams.Count - 1;
            //    var originalValAway = awayTeams.Count;

            //    Assert.AreEqual(expectedValHome, originalValHome);
            //    Assert.AreEqual(expectedValAway, originalValAway);

            //    foreach (Matchup matchup in homeTeams)
            //    {
            //        if (!homeTeamOpponents.Contains(matchup.AwayTeam))
            //        {
            //            homeTeamOpponents.Add(matchup.AwayTeam);
            //        }
            //    }
            //    foreach (Matchup matchup in awayTeams)
            //    {
            //        if (!awayTeamOpponents.Contains(matchup.HomeTeam))
            //        {
            //            awayTeamOpponents.Add(matchup.HomeTeam);
            //        }
            //    }

            //    var ogValHomeOpponent = homeTeamOpponents.Count;
            //    var ogValAwayOpponent = awayTeamOpponents.Count;

            //    Assert.AreEqual(expectedValHome, ogValHomeOpponent);
            //    Assert.AreEqual(expectedValAway, ogValAwayOpponent);

            //    homeTeams.Clear();
            //    awayTeams.Clear();
            //    homeTeamOpponents.Clear();
            //    awayTeamOpponents.Clear();
            //}
