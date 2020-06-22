using System;
using System.Collections.Generic;
using System.Text;
using TournamentLibrary.DataAccess;

namespace TournamentLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                //setup sql connector
                SqlConnector sql = new SqlConnector();
                connections.Add(sql);
            }
            if (textFiles)
            {
                //setup txt connector
                TextConnector text = new TextConnector();
                connections.Add(text);
            }
        }
    }
}
