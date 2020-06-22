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
using TournamentLibrary.DataAccess;
using TournamentLibrary.Models;

namespace TournamentUI
{
    public partial class CreatePrize : Form
    {
        public CreatePrize()
        {
            InitializeComponent();
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
             if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    PlaceNameValueLabel.Text, 
                    PlaceNumberValue.Text, 
                    PrizeAmountBox.Text, 
                    PrizePercentValue.Text);

                GlobalConfig.Connection.CreatePrize(model);

                PlaceNameValueLabel.Text = "";
                PlaceNumberValue.Text = "";
                PrizeAmountBox.Text = "0";
                PrizePercentValue.Text = "0";


            }
            else
            {
                MessageBox.Show("this form has invalid information, retry please");
            }
        }
        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            //returns boolian if it can be into or not and puts it into the out parameter variable
            bool PlaceNumberValid = int.TryParse(PlaceNumberValue.Text, out placeNumber);

            //next checks amount and percent in prize
            decimal prizeAmount = 0;
            double prizePercent = 0;
            bool prizeAmountValid = decimal.TryParse(PrizeAmountBox.Text, out prizeAmount);
            bool prizePercentValid = double.TryParse(PrizePercentValue.Text, out prizePercent);


            //placenumber checks
            if (!PlaceNumberValid)
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if (PlaceNameValueLabel.Text.Length == 0)
            {
                output = false;
            }

            //prizramount and price percent checks
            if (!prizeAmountValid || !prizePercentValid)
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePercent <= 0)
            {
                output = false;
            }

            if (prizePercent < 0 || prizePercent > 100)
            {
                output = false;
            }
            return output;
        }
    }
}
