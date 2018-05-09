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
// Date: April 2nd, 2018
// Goal: Display the results of integer division, integer modulo, and decimal division.

namespace DivisionDecVsMod___Eric_Klostermeyer
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
            decimal dividend = 0;
            decimal divisor = 1;

            bool dividendTest = decimal.TryParse(dividendBox.Text, out dividend);
            bool divisorTest = decimal.TryParse(divisorBox.Text, out divisor);

            // Processing
            if (!dividendTest || !divisorTest) {
                // Invalid characters
                MessageBox.Show("You have entered an invalid character. Please ensure your only have numeric characters.","Invalid Character");
            }
            else if (divisor == 0) {
                // Divide by zero error
                MessageBox.Show("Your divisor is zero, which cannot divide any number. Please make sure your divisor isn't zero and re-calculate.", "Divide By Zero Error");
            }
            else {
                // Processing & Output
                decimal result = 0;
                result = (int)dividend / (int)divisor;
                quotientAnswerLabel.Text = result.ToString();

                result = (int)dividend % (int)divisor;
                remainderAnswerLabel.Text = result.ToString();

                result = dividend / divisor;
                decimalDivisionLabel.Text = result.ToString("n4");
            }
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            // Clears all entries and results.
            dividendBox.Text = string.Empty;
            divisorBox.Text = string.Empty;
            quotientAnswerLabel.Text = string.Empty;
            remainderAnswerLabel.Text = string.Empty;
            decimalDivisionLabel.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ignore.
        }
    }
}
