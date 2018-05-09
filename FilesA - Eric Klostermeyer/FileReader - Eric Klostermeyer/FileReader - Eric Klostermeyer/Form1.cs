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
// should be held in the /bin/debug/. 

namespace FileReader___Eric_Klostermeyer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void readFileButton_Click(object sender, EventArgs e)
        {
            fileOutputListBox.Items.Clear();
            string fileName = fileNameBox.Text;
            string line = "";
            try
            {
                System.IO.StreamReader file =
                    new System.IO.StreamReader(@"..\Debug\" + fileName);

                while ((line = file.ReadLine()) != null)
                {
                    fileOutputListBox.Items.Add(line);
                }
                file.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("The file \"" + fileName + "\" does not exist. Check the name of the file and try again.", "File Not Found!");
            }
        }
    }
}
