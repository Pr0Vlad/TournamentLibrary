using System;
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
        List<PersonModel> GetPerson_All();
        TeamModel CreateTeam(TeamModel model);
        List<TeamModel> GetTeam_All();

        void CreateTournament(TournamentModel model);
    }
}
