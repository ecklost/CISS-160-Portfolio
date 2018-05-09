namespace ArrayOfStudents___Eric_Klostermeyer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.gradeBox = new System.Windows.Forms.TextBox();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.divider = new System.Windows.Forms.Label();
            this.viewArrayButton = new System.Windows.Forms.Button();
            this.studentListBox = new System.Windows.Forms.ListBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(82, 36);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(78, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Student Name:";
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(264, 36);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(171, 13);
            this.gradeLabel.TabIndex = 1;
            this.gradeLabel.Text = "Course Grade as Number (e.g. 75):";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(36, 52);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(172, 20);
            this.nameBox.TabIndex = 2;
            // 
            // gradeBox
            // 
            this.gradeBox.Location = new System.Drawing.Point(235, 52);
            this.gradeBox.Name = "gradeBox";
            this.gradeBox.Size = new System.Drawing.Size(228, 20);
            this.gradeBox.TabIndex = 3;
            this.gradeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(124, 95);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(247, 23);
            this.addStudentButton.TabIndex = 4;
            this.addStudentButton.Text = "Add Student to Array";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // divider
            // 
            this.divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider.Location = new System.Drawing.Point(25, 137);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(450, 2);
            this.divider.TabIndex = 5;
            // 
            // viewArrayButton
            // 
            this.viewArrayButton.Location = new System.Drawing.Point(124, 156);
            this.viewArrayButton.Name = "viewArrayButton";
            this.viewArrayButton.Size = new System.Drawing.Size(247, 23);
            this.viewArrayButton.TabIndex = 6;
            this.viewArrayButton.Text = "View Students Grades";
            this.viewArrayButton.UseVisualStyleBackColor = true;
            this.viewArrayButton.Click += new System.EventHandler(this.viewArrayButton_Click);
            // 
            // studentListBox
            // 
            this.studentListBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.studentListBox.FormattingEnabled = true;
            this.studentListBox.Location = new System.Drawing.Point(36, 196);
            this.studentListBox.Name = "studentListBox";
            this.studentListBox.Size = new System.Drawing.Size(427, 290);
            this.studentListBox.TabIndex = 7;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(124, 503);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(247, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear All (Array, Entries, List, etc.)";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 555);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.studentListBox);
            this.Controls.Add(this.viewArrayButton);
            this.Controls.Add(this.divider);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.gradeBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form1";
            this.Text = "bn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox gradeBox;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Label divider;
        private System.Windows.Forms.Button viewArrayButton;
        private System.Windows.Forms.ListBox studentListBox;
        private System.Windows.Forms.Button clearButton;
    }
}

