using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Author: Eric Klostermeyer
 * ID: 570042
 * Date: 2/28/2018
 * Goal: Create a calculator that keeps track of an order of mulch. The user inputs length,
 * width, and height (all in feet) and the calculator will track the current order of mulch,
 * all total orders, and how much load more a truck load can carry.
 */
namespace CalcWithAccums___Eric_Klostermeyer
{
    public partial class Form1 : Form
    {
        // Constants
        const decimal CUBIC_YARD = 27;
        const decimal PRICE_PER_CUBIC_YARD = 17.00m;
        const decimal TRUCK_BASE_CAPACITY = 4.00m;

        // Globals
        decimal totalOrderCubicFeet = 0;
        decimal totalOrderCubicYards = 0;
        decimal totalCost = 0;
        decimal totalNumberOfOrders = 0;

        public Form1()
        {
            InitializeComponent();
            emptyTruckCapacityTextBox.Text = "" + TRUCK_BASE_CAPACITY;
            currentPriceLabel.Text = "Current Price of One Cubic Yard = $" + PRICE_PER_CUBIC_YARD;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Input
            decimal lengthInDec = 0;
            decimal widthInDec = 0;
            decimal heightInDec = 0;
            decimal currentOrderCubicFeet = 0;
            decimal currentOrderCubicYards = 0;
            decimal currentOrderCost = 0;

            // We do not need to validate user input according to the project specifications.
            lengthInDec = decimal.Parse(lengthTextBox.Text);
            widthInDec = decimal.Parse(widthTextBox.Text);
            heightInDec = decimal.Parse(heightTextBox.Text);

            // Processing
            currentOrderCubicFeet = lengthInDec * widthInDec * heightInDec;
            currentOrderCubicYards = currentOrderCubicFeet / CUBIC_YARD;
            currentOrderCost = currentOrderCubicYards * PRICE_PER_CUBIC_YARD;

            totalOrderCubicFeet += currentOrderCubicFeet;
            totalOrderCubicYards += currentOrderCubicYards;
            totalCost += currentOrderCost;
            totalNumberOfOrders++;

            // Output
            cubicFeetOutputLabel.Text = "Cubic Feet: " + currentOrderCubicFeet;
            cubicYardsOutputLabel.Text = "Cubic Yards: " + decimal.Round(currentOrderCubicYards, 2);
            currentOrderPriceLabel.Text = "Cost: " + decimal.Round(currentOrderCost, 2);

            totalCubicFeetLabel.Text = "Total Cubic Feet: " + totalOrderCubicFeet;
            totalCubicYardsLabel.Text = "Total Cubic Yards: " + decimal.Round(totalOrderCubicYards, 2);
            totalCostLabel.Text = "Total Cost: " + decimal.Round(totalCost, 2);
            numberOfOrdersLabel.Text = "Number of Orders: " + totalNumberOfOrders;

            mulchOrderedTextBox.Text = "" + decimal.Round(totalOrderCubicYards, 2);
            remainingLoadTextBox.Text = "" + decimal.Round((TRUCK_BASE_CAPACITY - totalOrderCubicYards), 2);

            if ((TRUCK_BASE_CAPACITY - totalOrderCubicYards) < 0)
            {
                remainingLoadTextBox.BackColor = Color.Red;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear current entries.
            lengthTextBox.Text = string.Empty;
            widthTextBox.Text = string.Empty;
            heightTextBox.Text = string.Empty;
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            // Clear out and reset all non-constant values.
            lengthTextBox.Text = string.Empty;
            widthTextBox.Text = string.Empty;
            heightTextBox.Text = string.Empty;

            cubicFeetOutputLabel.Text = "Cubic Feet: ";
            cubicYardsOutputLabel.Text = "Cubic Yards: ";
            currentOrderPriceLabel.Text = "Cost: ";

            totalCubicFeetLabel.Text = "Total Cubic Feet: ";
            totalCubicYardsLabel.Text = "Total Cubic Yards: ";
            totalCostLabel.Text = "Total Cost: ";
            numberOfOrdersLabel.Text = "Number of Orders: ";

            mulchOrderedTextBox.Text = "";
            remainingLoadTextBox.Text = "";

            totalOrderCubicFeet = 0;
            totalOrderCubicYards = 0;
            totalCost = 0;
            totalNumberOfOrders = 0;

            remainingLoadTextBox.BackColor = Color.Lime;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Exit Program
            Close();
        }

    }
}
