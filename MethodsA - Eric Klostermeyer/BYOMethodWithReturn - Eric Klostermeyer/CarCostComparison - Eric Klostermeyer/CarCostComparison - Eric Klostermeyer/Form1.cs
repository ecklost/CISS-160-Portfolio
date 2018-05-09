using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Author: Eric Klostermeyer
// ID: 570042
// Date: 2/21/2018
// Goal: Compare the MPG, initial price, annual insurance cost, and annual repair cost of two cars.
// The car with the most costs over five years will be displayed in red.

namespace CarCostComparison___Eric_Klostermeyer
{
    public partial class S : Form
    {
        // Globals
        const decimal AVG_COST_OF_GAS = 2.50m;
        const decimal AVG_MILES_DRIVEN = 12000;

        Car carOne = new Car(); // For later. Right now used for holding variables.
        Car carTwo = new Car(); // Ditto.
        
        public S()
        {
            // I have no idea why the constructor is called S. Hm.
            InitializeComponent();
            carOneFiveYearTextBox.BackColor = Color.LightCyan;
            carTwoFiveYearCostTotal.BackColor = Color.LightCyan;

        }

        private decimal validEntry(string text)
        {
            // Do we have valid entries?
            decimal amount = 0;
            bool isNumber = decimal.TryParse(text, out amount);
            if (isNumber)
            {
                return amount;
            }
            else
            {
                return 0; // A car with 0 MPG is going nowhere. Especially with this program.
            }
        }

        private void calcYearGasTotal()
        {
            // Calculate gas total.
            try
            {
                // Car One
                // Inputs
                decimal mpg = 0;
                decimal perGallon = 0;
                decimal roundedPerGallon = 0;

                // Processing
                mpg = validEntry(carOneMPGTextBox.Text);
                perGallon = AVG_MILES_DRIVEN / mpg;
                roundedPerGallon = Math.Round((perGallon * AVG_COST_OF_GAS), 2);

                // Outputs
                carOneGasTotalTextBox.Text = "$" + roundedPerGallon;
                carOne.setYearlyGasTotal(roundedPerGallon);

                // Car two
                // Inputs are above
                // Processing
                mpg = validEntry(carTwoMPGTextBox.Text);
                perGallon = AVG_MILES_DRIVEN / mpg;
                roundedPerGallon = Math.Round((perGallon * AVG_COST_OF_GAS), 2);

                // Outputs
                carTwoGasTotalTextBox.Text = "$" + roundedPerGallon;
                carTwo.setYearlyGasTotal(roundedPerGallon);
            }
            catch (DivideByZeroException de)
            {
                MessageBox.Show("One of your boxes doesn't have a valid entry."
                    + " Ensure your MPG is above zero and doesn't contain errant characters", "Invalid Entry");
            }
        }

        private void calcFiveYearTotal()
        {
            // Five year total = initial purchase price + 5*gasTotal + 5*yearsRepair + 5*yearsInsurance

            // CAR ONE
            // Input
            decimal repairCost = 0;
            decimal insuranceCost = 0;
            decimal iniPrice = 0;
            decimal finalCost = 0;
            decimal carOneFinal = 0;

            // Processing
            bool isNumber = decimal.TryParse(carOneRepairCostTextBox.Text, out repairCost);
            if (!isNumber)
            {
                MessageBox.Show("Repair Cost has a invalid entry. Ensure there are no illegal characters." +
                    " Defaulting to $500.");
                repairCost = 500;
                carOneRepairCostTextBox.Text = "500";
            }

            
            isNumber = decimal.TryParse(carOneInsuranceCostTextBox.Text, out insuranceCost);
            if (!isNumber)
            {
                MessageBox.Show("Insurance Cost has an invalid entry. Ensure there are all characters are numbers." +
                    " Defaulting to $1000.");
                insuranceCost = 1000;
                carOneInsuranceCostTextBox.Text = "1000";
            }
            iniPrice = validEntry(carOneIniPriceTextBox.Text); // The car /could/ have been given away, so 0 is valid.
            finalCost = iniPrice + (5 * carOne.getYearlyGasTotal()) + (5 * repairCost) + (5 * insuranceCost);

            // Output
            carOneFiveYearTextBox.Text = "$" + Math.Round(finalCost, 2);
            carOneFinal = finalCost; // Holding this for comparison later.


            // CAR TWO
            // Processing
            repairCost = 0;
            isNumber = decimal.TryParse(carTwoRepairCostTextBox.Text, out repairCost);
            if (!isNumber)
            {
                MessageBox.Show("Repair Cost has a invalid entry. Ensure there are no illegal characters." +
                    " Defaulting to $500.");
                repairCost = 500;
                carTwoRepairCostTextBox.Text = "500";
            }

            insuranceCost = 0;
            isNumber = decimal.TryParse(carTwoInsuranceCostTextBox.Text, out insuranceCost);
            if (!isNumber)
            {
                MessageBox.Show("Insurance Cost has an invalid entry. Ensure there are all characters are numbers." +
                    " Defaulting to $1000.");
                insuranceCost = 1000;
                carTwoInsuranceCostTextBox.Text = "1000";
            }

            iniPrice = validEntry(carTwoIniPriceTextBox.Text); // The car /could/ have been given away, so 0 is valid.
            // If zero, we should italicize the zero regardless.

            finalCost = iniPrice + (5 * carTwo.getYearlyGasTotal()) + (5 * repairCost) + (5 * insuranceCost);

            // Output
            carTwoFiveYearCostTotal.Text = "$" + Math.Round(finalCost, 2);
            decimal carTwoFinal = finalCost; // Doing this for readability.

            // Highlight the car with the highest total as red.

            if (carOneFinal > carTwoFinal)
            {
                carOneFiveYearTextBox.BackColor = Color.Red;
            }
            else
            {
                carTwoFiveYearCostTotal.BackColor = Color.Red;
            }
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            // Calculate values.
            calcYearGasTotal();
            calcFiveYearTotal();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Reset all fields.
            carOne = new Car();
            carOneFiveYearTextBox.Text = string.Empty;
            carOneGasTotalTextBox.Text = string.Empty;
            carOneIniPriceTextBox.Text = string.Empty;
            carOneInsuranceCostTextBox.Text = string.Empty;
            carOneMakeTextBox.Text = string.Empty;
            carOneModelTextBox.Text = string.Empty;
            carOneMPGTextBox.Text = string.Empty;
            carOneRepairCostTextBox.Text = string.Empty;
            carOneYearTextBox.Text = string.Empty;
            carOneFiveYearTextBox.BackColor = Color.LightCyan;

            carTwo = new Car();
            carTwoFiveYearCostTotal.Text = string.Empty;
            carTwoGasTotalTextBox.Text = string.Empty;
            carTwoIniPriceTextBox.Text = string.Empty;
            carTwoInsuranceCostTextBox.Text = string.Empty;
            carTwoMakeTextBox.Text = string.Empty;
            carTwoModelTextBox.Text = string.Empty;
            carTwoMPGTextBox.Text = string.Empty;
            carTwoRepairCostTextBox.Text = string.Empty;
            carTwoYearTextBox.Text = string.Empty;
            carTwoFiveYearCostTotal.BackColor = Color.LightCyan;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Exit program.
            Close();
        }
    }
}
