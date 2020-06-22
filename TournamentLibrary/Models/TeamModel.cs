using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentLibrary.Models
{
    /// <summary>
    /// model for a team
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// people in the team
        /// </summary>
        public List<Person> TeamMembers { get; set; }
        /// <summary>
        /// name of the team
        /// </summary>
        public string TeamName { get; set; }
        /// <summary>
        /// getter constructor for adding new people
        /// </summary>
        public TeamModel()
        {
            TeamMembers = new List<Person>();
        }

    }
}
