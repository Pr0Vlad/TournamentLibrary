﻿
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TournamentLibrary.Models;
using System.Configuration;
using System.Threading.Tasks;
using Dapper;

namespace TournamentLibrary.DataAccess
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
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Tournaments")))
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                      
                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                return model;
            }
        }
    }
}