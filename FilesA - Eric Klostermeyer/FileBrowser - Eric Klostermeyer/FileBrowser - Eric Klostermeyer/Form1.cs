using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// Name: Eric Klostermeyer
// ID: 570042
// Date: 4/28/2018
// Goal: Given a user input, attempt to read the file the user wants to read. The file
// should be held in the /bin/debug/. Also allows the user to find a file using a browser.

namespace FileBrowser___Eric_Klostermeyer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void readFileButton_Click(object sender, EventArgs e)
        {
            // Input
            outputListBox.Items.Clear();
            string line = "";

            // Processing
            try
            {
                System.IO.StreamReader file =
                    new System.IO.StreamReader(@fileNameBox.Text);

                while ((line = file.ReadLine()) != null)
                {
                    // Output
                    outputListBox.Items.Add(line);
                }
                file.Close();
            }
            catch (FileNotFoundException)
            {
                // File not found.
                MessageBox.Show("The file \"" + fileNameBox.Text + "\" does not exist. Check the name of the file and try again.", "File Not Found!");
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            // Browse for .txt files
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileNameBox.Text = openFileDialog1.FileName;
            }
            else
            {
                fileNameBox.Text = "";
            }
        }
    }
}
