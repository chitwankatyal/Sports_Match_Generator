using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Assignment03
{
    public class TeamRepository : IRepository
    {
        public static string FileName = "assign04_teamData.json";

        private List<Team> _Teams;
        public List<Team> Teams
        {
            get
            {
                return _Teams;
            }
        }

        //Constructor
        public TeamRepository (string fileName)
        {
            Load(fileName);
        }

        //Methods
        public void TradePlayer (Player player, int startingTeamId, int destinationTeamId)
        {
            foreach (Team team in _Teams)
            {
                if (team.TeamId == startingTeamId)
                {
                    foreach (Player player1 in team.Roster)
                    {
                        if (player1.PlayerId == player.PlayerId)
                        {
                            team.Roster.Remove(player);
                            break;
                        }
                    }
                }
                else if (team.TeamId == destinationTeamId)
                {
                    player.Team = team;
                    team.Roster.Add(player);
                }
            }

            //Saving changes to the json file
            Save(TeamRepository.FileName);
        }
        public void Load (string fileName)
        {
            //Reading from the file
            
            string seedData = File.ReadAllText(fileName);

            //Deserialization of the file
            _Teams = JsonSerializer.Deserialize<List<Team>>(seedData);

            foreach (Team team in _Teams)
            {
                if (team.TeamId > Team.NextId)
                {
                    Team.NextId = team.TeamId;// + 1;
                }
                foreach (Player player in team.Roster)
                {
                    player.Team = team;
                    if (player.PlayerId > Player.NextId)
                    {
                        Player.NextId = player.PlayerId;// + 1;
                    }
                }
            }

        }
        public void Save (string fileName)
        {
            //Serialization of the file
            string jsonString = JsonSerializer.Serialize(Teams);
            File.WriteAllText(fileName, jsonString);
        }
    }
}
