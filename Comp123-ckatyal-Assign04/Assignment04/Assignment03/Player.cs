using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Assignment03
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public Team Team { get; set; }

        public bool EqualPlayer(Player player)
        {
            if (player != null)
            {
                if (this.PlayerId == player.PlayerId)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public static int NextId = 1;

        public Player()
        {

        }
        public Player(string name, Team team)
        {
            Name = name;
            Team = team;
            PlayerId = NextId++;
        }
    }
}
