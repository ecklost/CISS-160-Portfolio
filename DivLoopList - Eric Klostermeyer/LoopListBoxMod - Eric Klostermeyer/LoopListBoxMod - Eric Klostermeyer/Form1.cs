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
// Date: 4/2/2018
// Goal: Given a range of years (YYYY), list the years. If the corresponding checkboxes are marked,
// display that along with the year.

namespace LoopListBoxMod___Eric_Klostermeyer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loopButton_Click(object sender, EventArgs e)
        {
            // Input
            int startYear = 0;
            int endYear = 0;

            bool startYearValid = int.TryParse(startYearBox.Text, out startYear);
            bool endYearValid = int.TryParse(endYearBox.Text, out endYear);

            // Processing
            if (!startYearValid || !endYearValid)
            {
                MessageBox.Show("One or both year boxes contain invalid characters. Ensure they're are only numbers and try again.", "Invalid Characters");
            }
            else
            {
                resultListBox.Items.Clear(); // Clear all previous results.
                if (endYear < startYear)
                {
                    // Swap values.
                    int swap = 0;
                    swap = startYear;
                    startYear = endYear;
                    endYear = swap;
                }

                for (int i = startYear; i <= endYear ; i++)
                {
                    string item = "Year: " + i;
                    if (electionCheckBox.Checked && ((i % 4) == 0))
                    {
                        item += ", is an Election Year";
                    }
                    if (censusCheckBox.Checked && ((i % 10) == 0))
                    {
                        item += ", is a Census Year";
                    }
                    // Output
                    resultListBox.Items.Add(item);
                }
            }
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            // Clear all entries.
            startYearBox.Text = string.Empty;
            endYearBox.Text = string.Empty;
            electionCheckBox.Checked = false;
            censusCheckBox.Checked = false;
            resultListBox.Items.Clear();
        }
    }
}
