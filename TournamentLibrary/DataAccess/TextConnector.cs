using System;
using System.Collections.Generic;
using System.Text;
using TournamentLibrary.Models;
using TournamentLibrary.DataAccess.TextHelper;
using System.Linq;

namespace TournamentLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        private const string PeopleFile = "PeopleModels.csv";
        private const string TeamFile = "TeamModel.csv";
        private const string TournamentFile = "TournamentModels.csv";
        private const string MatchupFile = "MatchupModels.csv";
        private const string MatchupEntryFile = "MatchupEntryModels.csv";

        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> people = PeopleFile.fullFilePath().LoadFile().ConvertToPersonModels();
            int currentId = 1;
            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            people.Add(model);

            people.WriteToPeopleFile(PeopleFile);

            return model;
            
        }

        public PrizeModel CreatePrize(PrizeModel model)
        {   
            //loading textfile and converting it to a text List<orizemodel>
            List<PrizeModel> prizes = PrizesFile.fullFilePath().LoadFile().ConvertToPrizeModels();

            //find max id
            int currentId = 1;
            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
           
            model.Id = currentId;
     
            //adding new record with new id
            prizes.Add(model);

            //converting models and added models back into text and saving as text file/updating
            prizes.WriteToPrizeFile(PrizesFile);

            return model;
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = TeamFile.fullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);

            int currentId = 1;
            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            teams.Add(model);
            teams.WriteToTeamsFile(TeamFile);
            return model;
        }

        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = TournamentFile.fullFilePath().LoadFile().ConvertToTournamentModels(TeamFile, TeamFile, PrizesFile);

            int currentId = 1;

            if(tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            model.SaveRoundsToFile(MatchupFile, MatchupEntryFile);

            tournaments.Add(model);

            tournaments.SaveToTournamentFile(TournamentFile);
        }

        public List<PersonModel> GetPerson_All()
        {
            return PeopleFile.fullFilePath().LoadFile().ConvertToPersonModels();
        }

        public List<TeamModel> GetTeam_All()
        {
            return  TeamFile.fullFilePath().LoadFile().ConvertToTeamModels(PeopleFile);
        }

    }
}
 