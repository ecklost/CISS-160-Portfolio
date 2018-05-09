namespace FileReader___Eric_Klostermeyer
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
            this.enterFileNameLabel = new System.Windows.Forms.Label();
            this.fileNameBox = new System.Windows.Forms.TextBox();
            this.readFileButton = new System.Windows.Forms.Button();
            this.fileOutputListBox = new System.Windows.Forms.ListBox();
            this.fileOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterFileNameLabel
            // 
            this.enterFileNameLabel.AutoSize = true;
            this.enterFileNameLabel.Location = new System.Drawing.Point(13, 13);
            this.enterFileNameLabel.Name = "enterFileNameLabel";
            this.enterFileNameLabel.Size = new System.Drawing.Size(184, 13);
            this.enterFileNameLabel.TabIndex = 0;
            this.enterFileNameLabel.Text = "Enter File Name Below (ex. Test1.txt):";
            // 
            // fileNameBox
            // 
            this.fileNameBox.Location = new System.Drawing.Point(13, 30);
            this.fileNameBox.Name = "fileNameBox";
            this.fileNameBox.Size = new System.Drawing.Size(259, 20);
            this.fileNameBox.TabIndex = 1;
            // 
            // readFileButton
            // 
            this.readFileButton.Location = new System.Drawing.Point(85, 56);
            this.readFileButton.Name = "readFileButton";
            this.readFileButton.Size = new System.Drawing.Size(117, 23);
            this.readFileButton.TabIndex = 2;
            this.readFileButton.Text = "Read the File";
            this.readFileButton.UseVisualStyleBackColor = true;
            this.readFileButton.Click += new System.EventHandler(this.readFileButton_Click);
            // 
            // fileOutputListBox
            // 
            this.fileOutputListBox.FormattingEnabled = true;
            this.fileOutputListBox.Location = new System.Drawing.Point(16, 107);
            this.fileOutputListBox.Name = "fileOutputListBox";
            this.fileOutputListBox.Size = new System.Drawing.Size(256, 212);
            this.fileOutputListBox.TabIndex = 3;
            // 
            // fileOutputLabel
            // 
            this.fileOutputLabel.AutoSize = true;
            this.fileOutputLabel.Location = new System.Drawing.Point(16, 88);
            this.fileOutputLabel.Name = "fileOutputLabel";
            this.fileOutputLabel.Size = new System.Drawing.Size(105, 13);
            this.fileOutputLabel.TabIndex = 4;
            this.fileOutputLabel.Text = "Output of File Below:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 350);
            this.Controls.Add(this.fileOutputLabel);
            this.Controls.Add(this.fileOutputListBox);
            this.Controls.Add(this.readFileButton);
            this.Controls.Add(this.fileNameBox);
            this.Controls.Add(this.enterFileNameLabel);
            this.Name = "Form1";
            this.Text = "File Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterFileNameLabel;
        private System.Windows.Forms.TextBox fileNameBox;
        private System.Windows.Forms.Button readFileButton;
        private System.Windows.Forms.ListBox fileOutputListBox;
        private System.Windows.Forms.Label fileOutputLabel;
    }
}

