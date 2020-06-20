using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentLibrary
{
    public class SqlConnector : IDataConnection
    {
        /// <summary>
        /// saves a prize to database
        /// </summary>
        /// <param name="model"></param>
        /// <returns>prize info and its is, etc</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.id = 1;

            return model;
        }
    }
}
