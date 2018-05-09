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
// Goal: Determine the total shipping cost of an order using the following formula: Total shipping cost = (price per pound * entered weight) + zone charge.
// If the value is over 100.00, change the total cost to that and show a CAPPED label to the user.

namespace ShippingCalculator
{
    public partial class Form1 : Form
    {
        // Constants
        const decimal PRICE_PER_POUND = 10.00m;
        const decimal ZONE_A_SURCHARGE = 17.00m;
        const decimal ZONE_B_SURCHARGE = 34.15m;
        const decimal ZONE_C_SURCHARGE = 68.95m;
        const decimal CAPPED_PRICE = 100.00m;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            // Input
            decimal weight = 0;
            decimal currentWeightCost = 0;
            decimal currentZoneCost = 0;
            decimal totalCost = 0;

            decimal.TryParse(weightBox.Text, out weight);

            // Processing
            if (weight > 0)
            {
                // Then we can do the switch cases.
                switch (letterCodeBox.Text)
                {
                    case "a":
                    case "A":
                        currentZoneCost = ZONE_A_SURCHARGE;
                        currentWeightCost = weight * PRICE_PER_POUND;
                        totalCost = currentWeightCost + currentZoneCost;
                        if (totalCost > CAPPED_PRICE)
                        {
                            totalCost = CAPPED_PRICE;
                            cappedLabel.Visible = true;
                        }
                        else
                        {
                            cappedLabel.Visible = false;
                        }
                        // Output
                        weightCostLabel.Text = "Weight Cost: " + currentWeightCost.ToString("c");
                        zoneCostLabel.Text = "Zone Cost: " + currentZoneCost.ToString("c");
                        totalCostLabel.Text = "Total Cost: " + totalCost.ToString("c");
                        break;
                    case "b":
                    case "B":
                        currentZoneCost = ZONE_B_SURCHARGE;
                        currentWeightCost = weight * PRICE_PER_POUND;
                        totalCost = currentWeightCost + currentZoneCost;
                        if (totalCost > CAPPED_PRICE)
                        {
                            totalCost = CAPPED_PRICE;
                            cappedLabel.Visible = true;
                        }
                        else
                        {
                            cappedLabel.Visible = false;
                        }
                        // Output
                        weightCostLabel.Text = "Weight Cost: " + currentWeightCost.ToString("c");
                        zoneCostLabel.Text = "Zone Cost: " + currentZoneCost.ToString("c");
                        totalCostLabel.Text = "Total Cost: " + totalCost.ToString("c");
                        break;
                    case "c":
                    case "C":
                        currentZoneCost = ZONE_C_SURCHARGE;
                        currentWeightCost = weight * PRICE_PER_POUND;
                        totalCost = currentWeightCost + currentZoneCost;
                        if (totalCost > CAPPED_PRICE)
                        {
                            totalCost = CAPPED_PRICE;
                            cappedLabel.Visible = true;
                        }
                        else
                        {
                            cappedLabel.Visible = false;
                        }
                        // Output
                        weightCostLabel.Text = "Weight Cost: " + currentWeightCost.ToString("c");
                        zoneCostLabel.Text = "Zone Cost: " + currentZoneCost.ToString("c");
                        totalCostLabel.Text = "Total Cost: " + totalCost.ToString("c");
                        break;
                    default:
                        MessageBox.Show("Only Zone Codes 'A', 'B', and 'C' are accepted. Check your entry and re-calculate.", "Invalid Letter Code");
                        weightCostLabel.Text = "Weight Cost: ";
                        zoneCostLabel.Text = "Zone Cost: ";
                        totalCostLabel.Text = "Total Cost: ";
                        cappedLabel.Visible = false;
                        break;
                }
            }
            else
            {
                // The user has an invalid entry.
                MessageBox.Show("Weight must be a numberic value greater than zero. Make sure the field is not blank and free of spaces and non-numeric characters.","Invalid Weight");
                weightCostLabel.Text = "Weight Cost: ";
                zoneCostLabel.Text = "Zone Cost: ";
                totalCostLabel.Text = "Total Cost: ";
                cappedLabel.Visible = false;
            }
        }
    }
}
