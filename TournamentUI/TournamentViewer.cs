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
        BindingList<int> rounds = new BindingList<int>();
        BindingList<MatchupModel> selectedmatchups = new BindingList<MatchupModel>();

   
        public TournamentViewer(TournamentModel tournamentModel)
        {
            InitializeComponent();
            tournament = tournamentModel;
            connectLists();
            
            LoadForm();
            LoadRounds();
        }
        private void LoadForm()
        {
            TournamentNameLabel.Text = tournament.TournamentName;
        }

        private void connectLists()
        {
            //RoundDropDown.DataSource = null;          
            RoundDropDown.DataSource = rounds;
            MatchupListBox.DataSource = selectedmatchups;
            MatchupListBox.DisplayMember = "DisplayName";
        }

        
        private void LoadRounds()
        {
            
            rounds.Clear();
            rounds.Add(1);
            
            int currentRound = 1;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if(matchups.First().MatchupROund > currentRound)
                {
                    currentRound += 1;
                    rounds.Add(currentRound);
                    
                }
            }
            LoadMatchups(1);
        }

        private void RoundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)RoundDropDown.SelectedItem);
        }
        private void LoadMatchups(int round)
        {
            
            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupROund == round)
                {
                    selectedmatchups.Clear();
                    foreach(MatchupModel m in matchups)
                    {
                        selectedmatchups.Add(m);
                    }
                    
                }
            }
            loadMatchup(selectedmatchups.First());
        }
        private void loadMatchup(MatchupModel m)
        {
            

            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        TeamOneNameLabel.Text = m.Entries[0].TeamCompeting.TeamName;
                        TeamOneScoreValue.Text = m.Entries[0].Score.ToString();

                        TeamTwoLabel.Text = "<bye>";
                        TeamTwoScoreValue.Text = "0";
                    }
                    else
                    {
                        TeamOneNameLabel.Text = "Not set";
                        TeamOneScoreValue.Text = "0";
                    }
                }

                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        TeamTwoLabel.Text = m.Entries[1].TeamCompeting.TeamName;
                        TeamTwoScoreValue.Text = m.Entries[1].Score.ToString();
                    }
                    else
                    {
                        TeamTwoLabel.Text = "Not set";
                        TeamTwoScoreValue.Text = "0";
                    }
                }
            }
        }
        private void MatchupListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadMatchup((MatchupModel)MatchupListBox.SelectedItem);
        }
    }
}
