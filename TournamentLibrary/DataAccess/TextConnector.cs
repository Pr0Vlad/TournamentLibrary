using System;
using System.Collections.Generic;
using System.Text;
using TournamentLibrary.Models;

namespace TournamentLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
