using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentLibrary;
using TournamentLibrary.Models;

namespace TournamentUI
{
    public partial class CreateTeam : Form
    {
        public CreateTeam()
        {
            InitializeComponent();
        }

        private void TeamOneScoreValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void TeamNameValueBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SelectTeamMemberDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateTeam_Load(object sender, EventArgs e)
        {

        }

        private void creatememberbutton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName = FirstNameValue.Text;
                p.LastName = LastNameValue.Text;
                p.EmailAddress = EmailValue.Text;
                p.PhoneNumber = PhoneValue.Text;

                GlobalConfig.Connection.CreatePerson(p);

                FirstNameValue.Text = "";
                LastNameValue.Text = "";
                EmailValue.Text = "";
                PhoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill out all the fields");
            }

        }
        private bool ValidateForm()
        {
            //validation for the form so all info entered is correct syntax
            if (FirstNameValue.Text.Length == 0)
            {
                return false;
            }
            if (LastNameValue.Text.Length == 0)
            {
                return false;
            }
            if (EmailValue.Text.Length == 0)
            {
                return false;
            }
            if (PhoneValue.Text.Length == 0)
            {
                return false;
            }
            return true;
        }
    }
}
