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
// Date: 3/7/2018
// Goal: Determine the salary of a baseball player using a tiered system which is based on the number of hits they achieve.
//       Bonuses are applied if they are an all-star, MVP, or both.

namespace TieredPlayerSalaryViaIF___Eric_Klost
{
    public partial class Form1 : Form
    {
        // Constants
        const decimal MVP_OR_ALL_STAR_BONUS = 1.20m;
        const decimal MVP_AND_ALL_STAR_BONUS = 1.25m;

        // Global
        decimal leaderHits = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            // Input
            int hits = 0;
            decimal salary = 0;
            bool containsSpaces = nameTextBox.Text.Contains(' ');
            bool validInput = int.TryParse(hitsTextBox.Text, out hits);


            // Processing
            if (containsSpaces)
            {
                MessageBox.Show("Name only excepts non-space characters. Ensure you have no spaces and try again.", "No Spaces Allowed");
            }
            else
            {
                if (hits > 0 && hits <= 49)
                {
                    salary = hits * 17500;
                    resultThreeLabel.Text = "Tier 1";
                    determinePay(hits, salary);
                }
                else if (hits >= 50 && hits <= 99)
                {
                    salary = hits * 20000;
                    resultThreeLabel.Text = "Tier 2";
                    determinePay(hits, salary);
                }
                else if (hits >= 100 && hits <= 149)
                {
                    salary = hits * 22500;
                    resultThreeLabel.Text = "Tier 3";
                    determinePay(hits, salary);
                }
                else if (hits >= 150 && hits <= 300)
                {
                    salary = hits * 25000;
                    resultThreeLabel.Text = "Tier 4";
                    determinePay(hits, salary);
                }
                else
                {
                    MessageBox.Show("You have entered an invalid number of hits. The number must be between 1 and 300, and does not contain decimal places.", "Invalid Number");
                    resultThreeLabel.Text = "Invalid Tier";
                }
            }
        }

        private void determinePay(int hits, decimal salary)
        {
            // If we have a valid hit number we end up here.
            if (allStarCheckBox.Checked && mvpCheckBox.Checked)
            {
                salary = salary * MVP_AND_ALL_STAR_BONUS;
            }
            else if (allStarCheckBox.Checked || mvpCheckBox.Checked)
            {
                salary = salary * MVP_OR_ALL_STAR_BONUS;
            }

            // Output
            resultOneLabel.Text = nameTextBox.Text;
            resultTwoLabel.Text = hitsTextBox.Text;
            resultFourLabel.Text = salary.ToString("C");


            // Should we update the leader?
            if (hits > leaderHits)
            {
                leaderHits = hits;
                resultFiveLabel.Text = nameTextBox.Text;
                resultSixLabel.Text = hitsTextBox.Text;
                resultSevenLabel.Text = resultThreeLabel.Text;
                resultEightLabel.Text = salary.ToString("C");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear all fields.
            nameTextBox.Text = string.Empty;
            hitsTextBox.Text = string.Empty;

            allStarCheckBox.Checked = false;
            mvpCheckBox.Checked = false;

            resultOneLabel.Text = string.Empty;
            resultTwoLabel.Text = string.Empty;
            resultThreeLabel.Text = string.Empty;
            resultFourLabel.Text = string.Empty;
            resultFiveLabel.Text = string.Empty;
            resultSixLabel.Text = string.Empty;
            resultSevenLabel.Text = string.Empty;
            resultEightLabel.Text = string.Empty;
        }
    }
}
