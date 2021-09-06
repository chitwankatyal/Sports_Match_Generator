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
    public partial class TradePlayerForm : Form
    {
        //Fields
        private Player _player = new Player();
        private TeamRepository _teamRepository = new TeamRepository(TeamRepository.FileName);
        public TradePlayerForm(Player player, TeamRepository teamRepository)
        {
            InitializeComponent();

            _teamRepository = teamRepository;
            _player = player;

            PlayerNameLabel.Text = _player.Name;
            TeamNameLabel.Text = _player.Team.Name;

            //Adding the names of the teams to the list box excluding the team in which the selected player is
            foreach (Team team in _teamRepository.Teams)
            {
                if (team.Name != _player.Team.Name)
                {
                    newTeamListBox.Items.Add(team.Name);
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            int startingTeamId = _player.Team.TeamId;
            int destinationTeamId = 0;

            foreach (Team team in _teamRepository.Teams)
            {
                if (team.Name == newTeamListBox.GetItemText(newTeamListBox.SelectedItem))
                {
                    destinationTeamId = team.TeamId;
                    _teamRepository.TradePlayer(_player, startingTeamId, destinationTeamId);
                }
            }
            this.Close();
        }
    }
}
