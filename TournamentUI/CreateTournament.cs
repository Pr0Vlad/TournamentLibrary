using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentLibrary;
using TournamentLibrary.Models;

namespace TournamentUI
{
    public partial class CreateTournament : Form
    {
        List<TeamModel> availTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        public CreateTournament()
        {
            InitializeComponent();

            connectUpLists();
        }
        private void connectUpLists()
        {
            SelectTeamDropDown.DataSource = null;
            SelectTeamDropDown.DataSource = availTeams;
            SelectTeamDropDown.DisplayMember = "TeamName";

            TournTeamsListBox.DataSource = null;
            TournTeamsListBox.DataSource = selectedTeams;
            TournTeamsListBox.DisplayMember = "TeamName";

            PrizeslistBox.DataSource = null;
            PrizeslistBox.DataSource = selectedPrizes;
            PrizeslistBox.DisplayMember = "PlaceName";
        }

        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)SelectTeamDropDown.SelectedItem;

            if (t != null)
            {
                availTeams.Remove(t);
                selectedTeams.Add(t);

                connectUpLists();
            }
        }
    }
}
