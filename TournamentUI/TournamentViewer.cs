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
                        if (m.Winner != null || !UnplayedCheckBox.Checked)
                        {
                            selectedmatchups.Add(m);
                        }
                            
                    }
                    
                }
            }
            if (selectedmatchups.Count > 0)
            {
                loadMatchup(selectedmatchups.First());
            }
            DisplayMatchupInfo();
        }
        private void DisplayMatchupInfo()
        {
            bool isSeen = (selectedmatchups.Count > 0);
            TeamOneNameLabel.Visible = isSeen;
            TeamOneScoreLabel.Visible = isSeen;
            TeamOneScoreValue.Visible = isSeen;

            TeamTwoLabel.Visible = isSeen;
            TeamTwoScoreValueLabel.Visible = isSeen;
            TeamTwoScoreValue.Visible = isSeen;

            VsLabel.Visible = isSeen;
            scoreButton.Visible = isSeen;

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

        private void UnplayedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups((int)RoundDropDown.SelectedItem);
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            MatchupModel m = (MatchupModel)MatchupListBox.SelectedItem;
            double teamOne = 0;
            double teamTwo = 0;

            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        
                        bool scoregood = double.TryParse(TeamOneScoreValue.Text, out teamOne);
                        if (scoregood)
                        {
                            m.Entries[0].Score = teamOne;
                        }
                        else
                        {
                            MessageBox.Show("Enter a Valid Score for team 1");
                            return;
                        }
                        
                    }
                }

                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {           
                        bool scoregood = double.TryParse(TeamTwoScoreValue.Text, out teamTwo);
                        if (scoregood)
                        {
                            m.Entries[1].Score = teamTwo;
                        }
                        else
                        {
                            MessageBox.Show("Enter a Valid Score for team 2");
                            return;
                        }
                    }
                    
                }
            }
            if (teamOne > teamTwo)
            {
                m.Winner = m.Entries[0].TeamCompeting;
            }
            else if (teamTwo > teamOne)
            {
                m.Winner = m.Entries[1].TeamCompeting;
            }
            else
            {
                MessageBox.Show("Tie Game No Winner");
            }
            foreach (List<MatchupModel> round in tournament.Rounds)
            {
                foreach (MatchupModel rm in round)
                {
                    foreach (MatchupEntryModel me in rm.Entries)
                    {
                        if (me.ParentMatchup != null)
                        {
                            if (me.ParentMatchup.Id == m.Id)
                            {
                                me.TeamCompeting = m.Winner;
                                GlobalConfig.Connection.UpdateMatchup(rm);
                            }
                        }
                        
                    }
                }
            }

            LoadMatchups((int)RoundDropDown.SelectedItem);

            GlobalConfig.Connection.UpdateMatchup(m);
        }
    }
}
