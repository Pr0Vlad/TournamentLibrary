using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentLibrary.Models;

namespace TournamentUI
{
    public partial class TournamentViewer : Form
    {
        private TournamentModel tournament;
        List<int> rounds = new List<int>();
        List<MatchupModel> selectedmatchups = new List<MatchupModel>();
        public TournamentViewer(TournamentModel tournamentModel)
        {
            InitializeComponent();
            tournament = tournamentModel;
            LoadForm();
            LoadRounds();
        }
        private void LoadForm()
        {
            TournamentNameLabel.Text = tournament.TournamentName;
        }

        private void connectLists()
        {
            RoundDropDown.DataSource = null;
            RoundDropDown.DataSource = rounds;
            
        }

        private void connectListsTwo()
        {
            
            MatchupListBox.DataSource = null;
            MatchupListBox.DataSource = selectedmatchups;
            MatchupListBox.DisplayMember = "DisplayName";
        }
        private void LoadRounds()
        {
            rounds = new List<int>();
            rounds.Add(1);
            
            int currentRound = 1;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if(matchups.First().MatchupROund >= currentRound)
                {
                    currentRound += 1;
                    rounds.Add(currentRound);
                    
                }
            }
            connectLists();
        }

        private void RoundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups();
        }
        private void LoadMatchups()
        {
            int round = (int)RoundDropDown.SelectedItem;
            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupROund == round)
                {
                    selectedmatchups = matchups;
                }
            }
            connectListsTwo();
        }
    }
}
