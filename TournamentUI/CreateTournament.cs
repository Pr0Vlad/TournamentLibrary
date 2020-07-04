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
    public partial class CreateTournament : Form, IPrizeReq, ITeamReq
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

        private void CreatePrizeBotton_Click(object sender, EventArgs e)
        {
            CreatePrize frm = new CreatePrize(this);
            frm.Show();
        }

        public void PrizeComplete(PrizeModel model)
        {
            selectedPrizes.Add(model);
            connectUpLists();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            connectUpLists();
        }

        private void CreateTeamlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeam frm = new CreateTeam(this);
            frm.Show();
        }

        private void deleteprizebutton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)TournTeamsListBox.SelectedItem;
            if(t != null)
            {
                selectedTeams.Remove(t);
                availTeams.Add(t);

                connectUpLists(); 
            }
        }

        private void DeletePrizeButton_Click_1(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)PrizeslistBox.SelectedItem;

            if(p != null)
            {
                selectedPrizes.Remove(p);

                connectUpLists();
            }
        }

        private void CreateTournButoon_Click(object sender, EventArgs e)
        {
            decimal fee = 0;
            bool feeaccept = decimal.TryParse(EntryFeeValue.Text, out fee);

            if (!feeaccept)
            {
                MessageBox.Show("enter a valid entryfee", "invalid fee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TournamentModel tm = new TournamentModel();
            tm.TournamentName = TournamentNameBox.Text;
            tm.EntryFee = 0

            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;
        }
    }
}
