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

        public PersonModel CreatePerson(PersonModel model)
        {
            throw new NotImplementedException();
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
    }
}
