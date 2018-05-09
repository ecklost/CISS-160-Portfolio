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
// Date: 3/25/2018
// Goal: Allow a user to select a car and add options. Display the total cost and the breakdown of the cost with the parts.
// Note that I used the two cars currently in the garage as well as fairly fictious pricing on some of the items.

namespace UIControlsAndMultiLine___Eric_Klost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            // Input
            decimal carCost = 0;

            // Processing
            if (soulRadioButton.Checked)
            {
                carCost = 15000;
                carCost = addOptionalFeatures(carCost);
                displayResult(carCost, "2015 Kia Soul ($15,000)");
            }
            else if (mazdaRadioButton.Checked)
            {
                carCost = 17000;
                carCost = addOptionalFeatures(carCost);
                displayResult(carCost, "2016 Mazda 3 ($17,000)");
            }
            else
            {
                MessageBox.Show("You have not selected a car. Please choose a car.", "No Car Selected");
            }
        }

        private decimal addOptionalFeatures(decimal carCost)
        {
            if (sunRoofCheckBox.Checked)
            {
                carCost += 1000;
            }
            if (entertainmentCheckBox.Checked)
            {
                carCost += 1500;
            }
            if (racingPackageCheckBox.Checked)
            {
                carCost += 500;
            }
            return carCost;
        }

        private void displayResult(decimal carCost, string carName)
        {
            // Output
            resultLabel.Text = carCost.ToString("c");
            orderedLabel.Text = "YOU ORDERED:\n" + carName + "\n";
            if (!sunRoofCheckBox.Checked && !entertainmentCheckBox.Checked && !racingPackageCheckBox.Checked)
            {
                orderedLabel.Text += "Options: NONE";
            }
            else
            {
                if (sunRoofCheckBox.Checked)
                {
                    orderedLabel.Text += "Sun Roof ($1,000)\n";
                }
                if (entertainmentCheckBox.Checked)
                {
                    orderedLabel.Text += "Entertainment Package ($1,500)\n";
                }
                if (racingPackageCheckBox.Checked)
                {
                    orderedLabel.Text += "Racing Package ($500)";
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            orderedLabel.Text = string.Empty;
            resultLabel.Text = string.Empty;

            sunRoofCheckBox.Checked = false;
            entertainmentCheckBox.Checked = false;
            racingPackageCheckBox.Checked = false;

            soulRadioButton.Checked = false;
            mazdaRadioButton.Checked = false;
        }
    }
}
