using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public List<Player> Roster { get; set; } = new List<Player>();

        public static int NextId = 1;
        public Team()
        {

        }
        public Team (string name)
        {
            Name = name;
            TeamId = NextId++;
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
