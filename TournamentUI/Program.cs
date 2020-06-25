using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentLibrary;

namespace TournamentUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //initialize database connection
            //TournamentLibrary.GlobalConfig.InitializeConnections(DatabaseType.Sql);
            TournamentLibrary.GlobalConfig.InitializeConnections(DatabaseType.Textfile);

            //Application.Run(new tournamentDashBoard());
            Application.Run(new CreatePrize());
        }
    }
}
