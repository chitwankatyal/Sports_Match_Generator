using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    Chitwan Katyal
    301169422
    ckatyal@my.centennialcollege.ca
    ASSIGNMENT 04
 */

namespace Assignment03
{
    public partial class MainForm : Form
    {
        //Field
        private TeamRepository _teamRepository = new TeamRepository(TeamRepository.FileName);
        private MatchupRepository _matchupRepository = new MatchupRepository();
        public MainForm()
        {
            InitializeComponent();

            _teamRepository.Load(TeamRepository.FileName);
            DisplayTeamsAndPlayers();
        }
        private void DisplayTeamsAndPlayers()
        {
            teamsListBox.DataSource = _teamRepository.Teams;
            teamsListBox.DisplayMember = nameof(Team.Name);
        }

        private void TradePlayerButton_Click(object sender, EventArgs e)
        {
            TradePlayerForm tradePlayerForm = new TradePlayerForm(playersListBox.SelectedItem as Player, _teamRepository);
            tradePlayerForm.Show();
            tradePlayerForm.FormClosed += TradePlayerForm_FormClosed;
        }

        private void TradePlayerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _teamRepository.Load(TeamRepository.FileName);
            DisplayTeamsAndPlayers();
        }

        private void TeamsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Team team = teamsListBox.SelectedItem as Team;
            playersListBox.DataSource = team.Roster;
            playersListBox.DisplayMember = nameof(Player.Name);
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            AddTeamForm addTeamForm = new AddTeamForm();
            addTeamForm.Show();

            addTeamForm.FormClosed += AddTeamForm_FormClosed;
        }

        private void AddTeamForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _teamRepository.Load(TeamRepository.FileName);
            DisplayTeamsAndPlayers();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            AddPlayerForm addPlayerForm = new AddPlayerForm();
            addPlayerForm.Show();

            addPlayerForm.FormClosed += AddPlayerForm_FormClosed;
        }

        private void AddPlayerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _teamRepository.Load(TeamRepository.FileName);
            DisplayTeamsAndPlayers();
        }

        private void btnGenerateSeason_Click(object sender, EventArgs e)
        {
            SeasonForm seasonForm = new SeasonForm(_teamRepository.Teams);
            seasonForm.Show();
        }
    }
}
