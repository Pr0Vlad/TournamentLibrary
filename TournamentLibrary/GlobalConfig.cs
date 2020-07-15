using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using TournamentLibrary.DataAccess;


namespace TournamentLibrary
{
    public static class GlobalConfig

    {
        public const string PrizesFile = "PrizeModels.csv";
        public const string PeopleFile = "PeopleModels.csv";
        public const string TeamFile = "TeamModel.csv";
        public const string TournamentFile = "TournamentModels.csv";
        public const string MatchupFile = "MatchupModels.csv";
        public const string MatchupEntryFile = "MatchupEntryModels.csv";


        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DatabaseType db)
        {

            if (db == DatabaseType.Sql)
            {
                //setup sql connector
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if (db == DatabaseType.Textfile)
            {
                //setup txt connector
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
