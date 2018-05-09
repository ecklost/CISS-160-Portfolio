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
// Date: 4/23/2018
// Goal: Using arrays, store student names and a numeric grade of that student (up to five students). Display the
// the results in a ListBox along with number of entries and averages. Please ignore and List<> or Student values.

namespace ArrayOfStudents___Eric_Klostermeyer
{
    public partial class Form1 : Form
    {
        // Globals
        //List<Student> studentList = new List<Student>();
        string[] studentArray = new string[] { "STUDENT ONE", "STUDENT TWO", "STUDENT THREE", "STUDENT FOUR", "STUDENT FIVE" };
        int[] gradeArray = new int[] { 0, 0, 0, 0, 0 };

        int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            decimal grade = 0;
            bool validGrade = decimal.TryParse(gradeBox.Text, out grade);
            if (validGrade && counter != 5 && grade >= 0 && grade <= 100)
            {
                /*studentList.Add(new Student
                {
                    Name = nameBox.Text,
                    Grade = grade
                });*/
                studentArray[counter] = nameBox.Text;
                gradeArray[counter] = (int)grade;
                MessageBox.Show("You have successfully added a name and grade to array[" + counter + "]!", "Entry Successfully Added");
                nameBox.Text = string.Empty;
                gradeBox.Text = string.Empty;
                counter++;
            }
            else if (grade < 0 || grade > 100)
            {
                // Invalid grades.
                MessageBox.Show("Grades can only be between 0 and 100.","Invalid Grade Number");
            }
            else if (counter == 5)
            {
                // Throw an error.
                MessageBox.Show("You have entered more than five students. If you'd like to add more, click the clear button.", "Too Many Entries");
            }
            else
            {
                // Invalid entry
                MessageBox.Show("You have entered a value into the grade box that is non-numeric. Make sure the value is numeric and try again.", "Illegal Grade Value");
            }
        }

        private void viewArrayButton_Click(object sender, EventArgs e)
        {
            studentListBox.Items.Clear();

            decimal average = 0;

            for (int i = 0; i < 5 ; i++)
            {
                studentListBox.Items.Add("Student #" + (i+1) + ": " + studentArray[i] + " | " + gradeArray[i]);
                average += gradeArray[i];
            }
            studentListBox.Items.Add("Number of Students added successfully: " + (counter));
            if (counter > 0) studentListBox.Items.Add("Average Grade: " + (average / counter).ToString("n2"));
            else studentListBox.Items.Add("Average Grade: 0");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameBox.Text = string.Empty;
            gradeBox.Text = string.Empty;
            studentArray = new string[] { "STUDENT ONE", "STUDENT TWO", "STUDENT THREE", "STUDENT FOUR", "STUDENT FIVE" };
            gradeArray = new int[] { 0, 0, 0, 0, 0 };
            counter = 0;
            studentListBox.Items.Clear();
        }
    }
}
