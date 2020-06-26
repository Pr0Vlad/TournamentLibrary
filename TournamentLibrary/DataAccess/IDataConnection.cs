﻿using System;
using System.Collections.Generic;
using System.Text;
using TournamentLibrary.Models;
using System.Data.SqlClient;

namespace TournamentLibrary.DataAccess
{
    public interface IDataConnection
    {
        //different methods for creating/managing/models and connecting with database
        PrizeModel CreatePrize(PrizeModel model);
        PersonModel CreatePerson(PersonModel model);
    }
}
