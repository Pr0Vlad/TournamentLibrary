using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            TournamentLibrary.GlobalConfig.InitializeConnections(true, true);


            //Application.Run(new tournamentDashBoard());
            Application.Run(new CreatePrize());
        }
    }
}
