using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentLibrary
{
    public class TournamentModel
    {
        public string TournamentName { get; set; }
        public decimal EntryFee { get; set; }
        public List<TeamModel> EnteredTeams { get; set; }
        public List<PrizeModel> Prizes { get; set; }
        public List<List<MatchupModel>> Rounds { get; set; }

        public TournamentModel()
        {
            EnteredTeams = new List<TeamModel>();

            Prizes = new List<PrizeModel>();

            Rounds = new List<List<MatchupModel>>();
        }
    }
}
