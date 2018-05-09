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
// Date: Apr. 8th, 2018
// Goal: Using three numbers (0-9) chosen by the user, generate numbers until a match is found or one thousand
// attempts have been done. Display all results and whether they failed or succeeded.


namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ignore
        }

        private void luckyButton_Click(object sender, EventArgs e)
        {
            // Input
            int numberOne = 0;
            int numberTwo = 0;
            int numberThree = 0;

            bool isNumOneValid = int.TryParse(numberOneBox.Text, out numberOne);
            bool isNumTwoValid = int.TryParse(numberTwoBox.Text, out numberTwo);
            bool isNumThreeValid = int.TryParse(numberThreeBox.Text, out numberThree);

            if (!isNumOneValid || !isNumTwoValid || !isNumThreeValid)
            {
                // Invalid numbers
                MessageBox.Show("Your entered numbers contain non-numeric characters. Ensure there are no spaces or illegal characters and try again.", "Invalid Characters");
            }
            else if ((numberOne > 9 || numberOne < 0) || (numberTwo > 9 || numberTwo < 0) || (numberThree > 9 || numberThree < 0))
            {
                // Only single digits allowed.
                MessageBox.Show("You have input a number greater than ten or less than zero. Only single digits (0-9) are allowed.","Invalid Entered Numbers");
            }
            else
            {
                resultsListBox.Items.Clear();
                generatedNumOneBox.BackColor = default(Color);
                generatedNumTwoBox.BackColor = default(Color);
                generatedNumThreeBox.BackColor = default(Color);

                int attempts = 0;
                int randomNumOne = 0;
                int randomNumTwo = 0;
                int randomNumThree = 0;

                Random random = new Random();

                // Processing
                while (attempts <= 1000)
                {
                    attempts++;
                    randomNumOne = random.Next(0, 10);
                    randomNumTwo = random.Next(0, 10);
                    randomNumThree = random.Next(0, 10);

                    if (randomNumOne == numberOne && randomNumTwo == numberTwo && randomNumThree == numberThree)
                    {
                        // Output
                        generatedNumOneBox.Text = ""+randomNumOne;
                        generatedNumTwoBox.Text = ""+randomNumTwo;
                        generatedNumThreeBox.Text = ""+randomNumThree;

                        generatedNumOneBox.BackColor = Color.Lime;
                        generatedNumTwoBox.BackColor = Color.Lime;
                        generatedNumThreeBox.BackColor = Color.Lime;

                        attemptsBox.Text = attempts+"";

                        resultsListBox.Items.Add("Attempt #" + attempts + ": SUCCEEDS! Numbers are: "+ numberOne + numberTwo + numberThree + " vs " + randomNumOne + randomNumTwo + randomNumThree);
                        MessageBox.Show("Match found for your numbers! It took " + attempts + " tries!", "Match found!");
                        break;
                    }

                    resultsListBox.Items.Add("Attempt #" + attempts + ": Fails! Numbers are: " + numberOne + numberTwo + numberThree + " vs " + randomNumOne + randomNumTwo + randomNumThree);

                    if (attempts > 1000)
                    {
                        // Output
                        generatedNumOneBox.Text = randomNumOne.ToString();
                        generatedNumTwoBox.Text = randomNumTwo.ToString();
                        generatedNumThreeBox.Text = randomNumThree.ToString();

                        if (randomNumOne == numberOne)
                        {
                            generatedNumOneBox.BackColor = Color.Lime;
                        }

                        if (randomNumTwo == numberTwo)
                        {
                            generatedNumTwoBox.BackColor = Color.Lime;
                        }

                        if (randomNumThree == numberThree)
                        {
                            generatedNumThreeBox.BackColor = Color.Lime;
                        }

                        attemptsBox.Text = ""+1000;

                        MessageBox.Show("Your number combination was not found. Better luck next time!", "After 1000 attempts...");
                        break;
                    }
                }
            }
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            // Reset values
            numberOneBox.Text = string.Empty;
            numberTwoBox.Text = string.Empty;
            numberThreeBox.Text = string.Empty;

            generatedNumOneBox.Text = string.Empty;
            generatedNumTwoBox.Text = string.Empty;
            generatedNumThreeBox.Text = string.Empty;
            generatedNumOneBox.BackColor = default(Color);
            generatedNumTwoBox.BackColor = default(Color);
            generatedNumThreeBox.BackColor = default(Color);

            attemptsBox.Text = string.Empty;
            resultsListBox.Items.Clear();
        }
    }
}
