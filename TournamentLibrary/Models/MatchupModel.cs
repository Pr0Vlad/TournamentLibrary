using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentLibrary.Models

{/// <summary>
/// one match in the tournament
/// </summary>
    public class MatchupModel
    {
        public int Id { get; set; }
        /// <summary>
        /// set of teams in the match
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; }
        /// <summary>
        /// winner id from database used to find the winner
        /// </summary>
        public int WinnerId { get; set; }
        /// <summary>
        /// winner of the match
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// which round the match is part of
        /// </summary>
        public int MatchupROund { get; set; }

        public MatchupModel()
        {
            Entries = new List<MatchupEntryModel>();
        }

        public string DisplayName
        {
            get
            {
                string output = "";
                foreach (MatchupEntryModel me in Entries)
                {
                    if (me.TeamCompeting != null) 
                    { 
                        if (output.Length == 0)
                        {
                            output = me.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs. { me.TeamCompeting.TeamName }";
                        }
                    }
                    else
                    {
                        output = "Matchup Not Yet Known";
                        break;
                    }
                }
                return output;
            }
        }
    }
}
