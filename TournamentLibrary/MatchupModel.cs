using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentLibrary
    
{/// <summary>
/// one match in the tournament
/// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// set of teams in the match
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; }
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
    }
}
