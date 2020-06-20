using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentLibrary
{
    /// <summary>
    /// represents the prozes
    /// </summary>
    public class PrizeModel
    {  
        /// <summary>
        /// identifier id for the prize 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// place of team
        /// </summary>

        public int PlaceNumber { get; set; }
        /// <summary>
        /// name of the team in the place
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// how much prize is
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// percentage of the prize
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
