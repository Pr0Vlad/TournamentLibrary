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
    public partial class tournamentDashBoard : Form
    {
        List<TournamentModel> tournaments = GlobalConfig.Connection.GetTournament_All()
        public tournamentDashBoard()
        {
            InitializeComponent();
        }
    }
}
