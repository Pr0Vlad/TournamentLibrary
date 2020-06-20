using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentLibrary
{
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);
    }
}
