using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentLibrary
{
    public class TeamModel
    {
        public List<Person> TeamMembers { get; set; }
        public string TeamName { get; set; }

        public TeamModel()
        {
            TeamMembers = new List<Person>();
        }

    }
}
