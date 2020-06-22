using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentLibrary
{
    /// <summary>
    /// person model
    /// </summary>
    public class Person
    {
        /// <summary>
        /// firstname
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// lastname
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// email address
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// phone number
        /// </summary>
        public string PhoneNumber { get; set; }

        public Person()
        {

        }
    }
}
