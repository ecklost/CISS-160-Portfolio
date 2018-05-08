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
 * Goal: Calcualte the MPG, miles traveled and cost of a fill-up for a car trip 
 * from gas station 1 to gas station 2. The entries will need to be verified that
 * they are correct.
 */

namespace CalcValidation___Eric_Klostermeyer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            totalCostResultLabel.Text = "Result 1";
            milesResultLabel.Text = "Result 2";
            mpgResultLabel.Text = "Result 3";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Input
            decimal gallonsFilled = 0;
            decimal pricePerGallon = 0;
            decimal beginOdometerReading = 0;
            decimal endOdometerReading = 0;
            decimal totalCost = 0;
            decimal milesTraveled = 0;
            bool result = true;

            try
            {
                // Processing
                result = decimal.TryParse(gallonsFilledTextBox.Text, out gallonsFilled);

                // Invalid entries just go to default values.
                if (gallonsFilled <= 0 && !result)
                {
                    MessageBox.Show("Gallons filled not set correctly. Defaulting to 12.");
                    gallonsFilled = 12;
                    gallonsFilledTextBox.Text = "" + 12;
                }

                result = decimal.TryParse(pricePerGallonTextBox.Text, out pricePerGallon);

                if (pricePerGallon <= 0 && !result)
                {
                    MessageBox.Show("Price per Gallon is not set correctly. Defaulting to $2.50");
                    pricePerGallon = 2.50m;
                    pricePerGallonTextBox.Text = "" + 2.50;
                }

                result = decimal.TryParse(beginningOdometerTextBox.Text, out beginOdometerReading);

                if (beginOdometerReading <= 0 && !result)
                {
                    MessageBox.Show("Beginning Odometer Reading not set correctly. Defaulting to 8800");
                    beginOdometerReading = 8800;
                    beginningOdometerTextBox.Text = "" + 8800;
                }

                result = decimal.TryParse(endingOdometerTextBox.Text, out endOdometerReading);

                if (endOdometerReading <= 0 && !result)
                {
                    MessageBox.Show("Ending Odometer Reading not set correctly. Defaulting to 9250");
                    endOdometerReading = 9250;
                    endingOdometerTextBox.Text = "" + 9250;
                }

                if (endOdometerReading < beginOdometerReading)
                {
                    // Swap the values.
                    MessageBox.Show("Ending odometer reading cannot be less than the beginning reading. Swapping entries.");
                    decimal.TryParse(beginningOdometerTextBox.Text, out endOdometerReading);
                    decimal.TryParse(endingOdometerTextBox.Text, out beginOdometerReading);

                    beginningOdometerTextBox.Text = "" + beginOdometerReading;
                    endingOdometerTextBox.Text = "" + endOdometerReading;
                }

                totalCost = gallonsFilled * pricePerGallon;
                milesTraveled = endOdometerReading - beginOdometerReading;
                
                // Output
                totalCostResultLabel.Text = "" + decimal.Round(totalCost, 2);
                milesResultLabel.Text = "" + milesTraveled;
                mpgResultLabel.Text = "" + decimal.Round((milesTraveled / gallonsFilled), 2);
            }
            catch (Exception)
            {
                MessageBox.Show("You have entered an invalid character into one or more field. Only numbers are allowed.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ignore.
        }
    }
}
