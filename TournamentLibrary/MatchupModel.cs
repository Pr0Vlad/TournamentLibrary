using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentLibrary
{
    class MatchupModel
    {
        public List<MatchupEntryModel> Entries { get; set; }

        public TeamModel Winner { get; set; }
        public int MatchupROund { get; set; }

        public MatchupModel()
        {
            Entries = new List<MatchupEntryModel>();
        }
    }
}
