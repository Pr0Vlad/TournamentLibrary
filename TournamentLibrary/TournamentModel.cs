using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentLibrary
{
    /// <summary>
    /// model for the tournament
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// name of it
        /// </summary>

        public string TournamentName { get; set; }
        /// <summary>
        /// fee to enter
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// teams in it
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; }
        /// <summary>
        /// prizes available
        /// </summary>
        public List<PrizeModel> Prizes { get; set; }
        /// <summary>
        /// rounds in the tournament
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; }
        /// <summary>
        /// constructor for setters
        /// </summary>
        public TournamentModel()
        {
            EnteredTeams = new List<TeamModel>();

            Prizes = new List<PrizeModel>();

            Rounds = new List<List<MatchupModel>>();
        }
    }
}
