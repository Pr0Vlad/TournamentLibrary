﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentLibrary.Models
{
    /// <summary>
    /// person model
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// identifier id for the person 
        /// </summary>
        public int Id { get; set; }
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
        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }
        public PersonModel()
        {

        }
    }
}
