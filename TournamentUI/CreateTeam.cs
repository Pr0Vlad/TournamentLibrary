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
        private List<PersonModel> availTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        private ITeamReq callingForm;
        public CreateTeam(ITeamReq caller)
        {
            InitializeComponent();
            callingForm = caller;
            //testing
            //MakeSample();

            WireUpLists();
        }
       
        private void MakeSample()
        {
            availTeamMembers.Add(new PersonModel { FirstName = "just", LastName = "working" });
            availTeamMembers.Add(new PersonModel { FirstName = "pashka", LastName = "pavel" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "someone", LastName = "no one" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "test", LastName = "tester" });
        }
        private void WireUpLists()
        {
            //to force a refresh
            SelectTeamMemberDropDown.DataSource = null;

            SelectTeamMemberDropDown.DataSource = availTeamMembers;
            SelectTeamMemberDropDown.DisplayMember = "FullName";

            TeamMembersListBox.DataSource = null;

            TeamMembersListBox.DataSource = selectedTeamMembers;
            TeamMembersListBox.DisplayMember = "FullName";

            
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

                p = GlobalConfig.Connection.CreatePerson(p);
                selectedTeamMembers.Add(p);
                WireUpLists();

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

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)SelectTeamMemberDropDown.SelectedItem;

            if (p != null)
            {
                availTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists();
            }
        }

        private void RemovMemberbutton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)TeamMembersListBox.SelectedItem;
            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availTeamMembers.Add(p);
                WireUpLists();
            }
        }

        private void CreateTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = TeamNameValueBox.Text;
            t.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connection.CreateTeam(t);

            callingForm.TeamComplete(t);
            this.Close();
        }
    }
}
