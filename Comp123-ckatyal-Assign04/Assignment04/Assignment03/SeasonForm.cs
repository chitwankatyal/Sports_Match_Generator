using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment03
{
    public partial class SeasonForm : Form
    {
        private MatchupRepository _matchupRepository = new MatchupRepository();
        private List<Team> _teams;
        
        public SeasonForm (List<Team> teams)
        {
            InitializeComponent();
            _teams = teams;
            _matchupRepository.GenerateSeason(teams);
            DisplayeSeasonGrid.DataSource = _matchupRepository.Matchups;

        }
        
    }
}
