using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace TournamentLibrary.Models
{
    /// <summary>
    /// represents the prozes
    /// </summary>
    public class PrizeModel
    {  
        /// <summary>
        /// identifier id for the prize 
        /// </summary>
        public int Id { get; set; }
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

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            //parsing the place value
            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            //parsing prizeamount
            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            //parsing the prize percentage
            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
