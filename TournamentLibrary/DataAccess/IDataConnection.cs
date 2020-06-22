using System;
using System.Collections.Generic;
using System.Text;
using TournamentLibrary.Models;
using System.Data.SqlClient;

namespace TournamentLibrary.DataAccess
{
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
    }
}
