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
    public partial class AddPlayerForm : Form
    {
        TeamRepository teamRepository = new TeamRepository(TeamRepository.FileName);
        public AddPlayerForm()
        {
            InitializeComponent();

            teamRepository.Load(TeamRepository.FileName);

            addedTeamListBox.DataSource = teamRepository.Teams;
            addedTeamListBox.DisplayMember = nameof(Team.Name);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            var team = teamRepository.Teams.FirstOrDefault(t => t.TeamId == (addedTeamListBox.SelectedItem as Team).TeamId);

            Player player = new Player(newPlayerTxtBox.Text, team);
            player.Name = newPlayerTxtBox.Text;
            player.PlayerId = Player.NextId;
        
            team.Roster.Add(player);
            teamRepository.Save(TeamRepository.FileName);

            Close();
        }
    }
}
