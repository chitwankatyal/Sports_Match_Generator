using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Assignment03
{
    public class MatchupRepository : IRepository
    {
        //Fields and Properties
        public static string matchupFile = "matchups.data.json";

        private List<Matchup> _Matchups = new List<Matchup>();
        public List<Matchup> Matchups => _Matchups;

        //Methods
        public void GenerateSeason(List<Team> teams)
        {
            Matchup matchup = new Matchup();

            foreach (Team homeTeam in teams)
            {
                if (homeTeam.Roster.Count() > 0 && homeTeam.Roster != null)
                {
                    foreach (Team awayTeam in teams)
                    {
                        if (homeTeam.TeamId != awayTeam.TeamId && awayTeam.Roster.Count() > 0 && awayTeam.Roster != null)
                        {
                            _Matchups.Add(new Matchup(homeTeam, awayTeam));
                        }

                    }
                }
               
            }
            Save(matchupFile);

        }
        public void Load (string matchupFile)
        {
            string seedData = File.ReadAllText(matchupFile);
            _Matchups = JsonSerializer.Deserialize<List<Matchup>>(seedData);
        }
        public void Save (string matchupFile)
        {
            //Serialization of the file
            string jsonString = JsonSerializer.Serialize(Matchups);
            File.WriteAllText(matchupFile, jsonString);

        }
    }
}
