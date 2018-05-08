// Author: Eric Klostermeyer
// ID: 570042
// Date: 2/15/2018
// Goal: Create a simple sales tax calculator for sales in Lorain County, Ohio.
// Make sure to make a test plan!

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
// Goal: Accuratly calculate the total amount of an item with a sales tax. Display the results.

namespace SalesTaxCalculator___Eric_Klostermeyer
{
    public partial class Form1 : Form
    {
        const decimal LORAIN_COUNTY_SALES_TAX = 0.0675m; // Source: https://www.tax.ohio.gov/sales_and_use/rate_changes.aspx

        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            // Input
            decimal initialCost = 0;

            // Processing
            bool isNumber = decimal.TryParse(salesTextBox.Text, out initialCost);
            Console.WriteLine("Initial cost: " + initialCost);
            if (isNumber)
            {
                // calculate
                decimal tax = initialCost * (LORAIN_COUNTY_SALES_TAX);
                tax = decimal.Round(tax, 2);
                initialCost = decimal.Round(initialCost, 2);
                
                // Output
                addedTaxTextBox.Text = "$" + tax;
                totalTextBox.Text = "$" + (initialCost + tax);
            }
            else
            {
                MessageBox.Show("You have entered an invalid character. Only numbers are allowed.", "Invalid Character Exception");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear relevant fields.
            salesTextBox.Text = string.Empty;
            addedTaxTextBox.Text = string.Empty;
            totalTextBox.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ignore
        }
    }
}
