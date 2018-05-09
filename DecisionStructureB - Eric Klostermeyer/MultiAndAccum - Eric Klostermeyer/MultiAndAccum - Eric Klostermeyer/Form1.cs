using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Name: Eric Klostermeyer
// ID: 570042
// Date: 3/11/2018
// Goal: Using everything we've learned in chapters 1 - 4, multiply two values input by a user. Validation of numbers is required.

namespace MultiAndAccum___Eric_Klostermeyer
{
    public partial class CH1to4Summary : Form
    {
        // Global
        decimal runningTotal = 0;

        public CH1to4Summary()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            // Input
            decimal numberOne = 0;
            decimal numberTwo = 0;
            decimal result = 0;

            bool validNumberOne = decimal.TryParse(numberOneBox.Text, out numberOne);
            bool validNumberTwo = decimal.TryParse(numberTwoBox.Text, out numberTwo);

            // Processing
            if (!validNumberOne || !validNumberTwo)
            {
                MessageBox.Show("One or both of the numbers entered contain non-numeric characters or spaces. Check that they do not and attempt to calculate again", "Invalid Entry");
            }
            else
            {
                result = numberOne * numberTwo;
                runningTotal += result;

                // Output
                actualResultsLabel.Text = result.ToString("#.##");
                runningTotalLabel.Text = runningTotal.ToString("#.##");
                if (runningTotal == 0) runningTotalLabel.Text = "0.00";
            }

            if (runningTotal <= 0)
            {
                runningTotalLabel.BackColor = Color.LightYellow;
            }
            else
            {
                runningTotalLabel.BackColor = Color.LightGreen;
            }
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            // Clear all entries.
            numberOneBox.Text = string.Empty;
            numberTwoBox.Text = string.Empty;
            actualResultsLabel.Text = string.Empty;
            runningTotalLabel.Text = string.Empty;
            runningTotal = 0;
            runningTotalLabel.BackColor = Color.PaleTurquoise;
        }
    }
}
