﻿using System;
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
        List<TournamentModel> tournaments = GlobalConfig.Connection.GetTournament_All();
        public tournamentDashBoard()
        {
            InitializeComponent();

            ConnectLists();
        }
        private void ConnectLists()
        {
            TournamentDropDown.DataSource = tournaments;
            TournamentDropDown.DisplayMember = "TournamentName";
        }

        private void CreateTournButton_Click(object sender, EventArgs e)
        {
            CreateTournament frm = new CreateTournament();
            frm.Show();
        }

        private void LoadTOurnButton_Click(object sender, EventArgs e)
        {
            TournamentModel tm = (TournamentModel)TournamentDropDown.SelectedItem;
            TournamentViewer frm = new TournamentViewer(tm);
            frm.Show();
        }
    }
}
