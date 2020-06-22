using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentLibrary.Models
{
    public class MatchupEntryModel
    
    {
        /// <summary>
        /// represents one matchup team
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// score for this team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// shows a matchup fopr team that came from winner
        /// </summary>
       
        public MatchupModel ParentMatchup { get; set; }

        

    }
}
