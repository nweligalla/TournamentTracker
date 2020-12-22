using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNumberValue.Text,
                    placeNameText.Text,
                    prizeAmountValue.Text,
                    prizePercentageValue.Text);

                foreach (IDataConnection db in GlobalConfig.connections)
                {
                    db.createPrize(model);
                }

                placeNumberValue.Text = "";
                placeNameText.Text = "";
                prizeAmountValue.Text = "0";
                prizePercentageValue.Text = "0";

            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }

        private bool validateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool isPlaceNumberValid = int.TryParse(placeNumberValue.Text, out placeNumber);

            decimal prizeAmount = 0;
            int prizePercentage = 0;

            bool isPrizeAmountValid = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool isPrizePercentageValid = int.TryParse(prizePercentageValue.Text, out prizePercentage);


            if (!isPlaceNumberValid)
                output = false;
            if (placeNumber < 1)
                output = false;
            if (placeNumberValue.Text.Length == 0)
                output = false;
            if (!isPrizeAmountValid || !isPrizePercentageValid)
                output = false;
            if (prizeAmount <= 0 && prizePercentage <= 0)
                output = false;
            if (prizePercentage < 0 || prizePercentage > 100)
                output = false;

            return output;
        }
    }
}
