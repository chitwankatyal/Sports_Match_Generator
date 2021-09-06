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
    public partial class AddTeamForm : Form
    {
        TeamRepository teamRepository = new TeamRepository(TeamRepository.FileName);
        public AddTeamForm()
        {
            InitializeComponent();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Team team = new Team(newTeamNameTxtBox.Text);
            team.Name = newTeamNameTxtBox.Text;
            team.TeamId = Team.NextId;

            teamRepository.Teams.Add(team);
            teamRepository.Save(TeamRepository.FileName);

            Close();
        }
    }
}
