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
        public CreateTournament()
        {
            InitializeComponent();

            InitializeLists();
        }
        private void InitializeLists()
        {
            SelectTeamDropDown.DataSource = availTeams;
            SelectTeamDropDown.DisplayMember = "TeamName";
        }
    }
}
