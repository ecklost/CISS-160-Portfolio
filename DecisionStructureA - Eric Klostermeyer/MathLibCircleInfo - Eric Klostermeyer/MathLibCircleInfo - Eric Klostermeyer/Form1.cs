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
// Date: 3/7/2018
// Goal: Given a user input for a radius, calculate the circle's diameter, circumference, and area.

namespace MathLibCircleInfo___Eric_Klostermeyer
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
            decimal radius = 0;
            double diameter = 0;
            double circumference = 0;
            double area = 0;

            // Processing
            bool validInput = decimal.TryParse(radiusEntryTextBox.Text, out radius);
            if (!validInput)
            {
                // Send error.
                MessageBox.Show("Ensure your entry does not contain illegal characters and try again.", "Invalid Radius");
            }
            else
            {
                diameter = (double)radius * 2;
                circumference = diameter * Math.PI;
                area = Math.PI * Math.Pow((double)radius, 2);

                // Output
                diameterResultBox.Text = diameter.ToString("#.##");
                circumferenceResultBox.Text = circumference.ToString("#.##");
                areaResultBox.Text = area.ToString("#.##");
            }
        }
    }
}
