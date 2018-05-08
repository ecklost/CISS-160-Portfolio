namespace CalcValidation___Eric_Klostermeyer
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
            this.beginningOdometerLabel = new System.Windows.Forms.Label();
            this.beginningOdometerTextBox = new System.Windows.Forms.TextBox();
            this.endingOdometerLabel = new System.Windows.Forms.Label();
            this.endingOdometerTextBox = new System.Windows.Forms.TextBox();
            this.gallonsFilledLabel = new System.Windows.Forms.Label();
            this.gallonsFilledTextBox = new System.Windows.Forms.TextBox();
            this.pricePerGallonTextBox = new System.Windows.Forms.TextBox();
            this.pricePerGallonLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.milesTraveledLabel = new System.Windows.Forms.Label();
            this.mpgLabel = new System.Windows.Forms.Label();
            this.totalCostResultLabel = new System.Windows.Forms.Label();
            this.milesResultLabel = new System.Windows.Forms.Label();
            this.mpgResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // beginningOdometerLabel
            // 
            this.beginningOdometerLabel.AutoSize = true;
            this.beginningOdometerLabel.Location = new System.Drawing.Point(13, 13);
            this.beginningOdometerLabel.Name = "beginningOdometerLabel";
            this.beginningOdometerLabel.Size = new System.Drawing.Size(149, 13);
            this.beginningOdometerLabel.TabIndex = 0;
            this.beginningOdometerLabel.Text = "Beginning Odometer Reading:";
            // 
            // beginningOdometerTextBox
            // 
            this.beginningOdometerTextBox.Location = new System.Drawing.Point(168, 10);
            this.beginningOdometerTextBox.Name = "beginningOdometerTextBox";
            this.beginningOdometerTextBox.Size = new System.Drawing.Size(100, 20);
            this.beginningOdometerTextBox.TabIndex = 1;
            // 
            // endingOdometerLabel
            // 
            this.endingOdometerLabel.AutoSize = true;
            this.endingOdometerLabel.Location = new System.Drawing.Point(13, 39);
            this.endingOdometerLabel.Name = "endingOdometerLabel";
            this.endingOdometerLabel.Size = new System.Drawing.Size(135, 13);
            this.endingOdometerLabel.TabIndex = 2;
            this.endingOdometerLabel.Text = "Ending Odometer Reading:";
            // 
            // endingOdometerTextBox
            // 
            this.endingOdometerTextBox.Location = new System.Drawing.Point(168, 36);
            this.endingOdometerTextBox.Name = "endingOdometerTextBox";
            this.endingOdometerTextBox.Size = new System.Drawing.Size(100, 20);
            this.endingOdometerTextBox.TabIndex = 3;
            // 
            // gallonsFilledLabel
            // 
            this.gallonsFilledLabel.AutoSize = true;
            this.gallonsFilledLabel.Location = new System.Drawing.Point(30, 69);
            this.gallonsFilledLabel.Name = "gallonsFilledLabel";
            this.gallonsFilledLabel.Size = new System.Drawing.Size(75, 13);
            this.gallonsFilledLabel.TabIndex = 4;
            this.gallonsFilledLabel.Text = "Gallons Filled: ";
            // 
            // gallonsFilledTextBox
            // 
            this.gallonsFilledTextBox.Location = new System.Drawing.Point(16, 85);
            this.gallonsFilledTextBox.Name = "gallonsFilledTextBox";
            this.gallonsFilledTextBox.Size = new System.Drawing.Size(100, 20);
            this.gallonsFilledTextBox.TabIndex = 5;
            // 
            // pricePerGallonTextBox
            // 
            this.pricePerGallonTextBox.Location = new System.Drawing.Point(168, 85);
            this.pricePerGallonTextBox.Name = "pricePerGallonTextBox";
            this.pricePerGallonTextBox.Size = new System.Drawing.Size(100, 20);
            this.pricePerGallonTextBox.TabIndex = 6;
            // 
            // pricePerGallonLabel
            // 
            this.pricePerGallonLabel.AutoSize = true;
            this.pricePerGallonLabel.Location = new System.Drawing.Point(170, 69);
            this.pricePerGallonLabel.Name = "pricePerGallonLabel";
            this.pricePerGallonLabel.Size = new System.Drawing.Size(97, 13);
            this.pricePerGallonLabel.TabIndex = 7;
            this.pricePerGallonLabel.Text = "Price per Gallon ($)";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(103, 111);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(13, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 2);
            this.label1.TabIndex = 9;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(30, 160);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(103, 13);
            this.totalCostLabel.TabIndex = 10;
            this.totalCostLabel.Text = "Total Cost of Fill-up: ";
            // 
            // milesTraveledLabel
            // 
            this.milesTraveledLabel.AutoSize = true;
            this.milesTraveledLabel.Location = new System.Drawing.Point(30, 188);
            this.milesTraveledLabel.Name = "milesTraveledLabel";
            this.milesTraveledLabel.Size = new System.Drawing.Size(82, 13);
            this.milesTraveledLabel.TabIndex = 11;
            this.milesTraveledLabel.Text = "Miles Traveled: ";
            // 
            // mpgLabel
            // 
            this.mpgLabel.AutoSize = true;
            this.mpgLabel.Location = new System.Drawing.Point(30, 216);
            this.mpgLabel.Name = "mpgLabel";
            this.mpgLabel.Size = new System.Drawing.Size(89, 13);
            this.mpgLabel.TabIndex = 12;
            this.mpgLabel.Text = "Miles Per Gallon: ";
            // 
            // totalCostResultLabel
            // 
            this.totalCostResultLabel.AutoSize = true;
            this.totalCostResultLabel.Location = new System.Drawing.Point(168, 160);
            this.totalCostResultLabel.Name = "totalCostResultLabel";
            this.totalCostResultLabel.Size = new System.Drawing.Size(0, 13);
            this.totalCostResultLabel.TabIndex = 13;
            // 
            // milesResultLabel
            // 
            this.milesResultLabel.AutoSize = true;
            this.milesResultLabel.Location = new System.Drawing.Point(168, 188);
            this.milesResultLabel.Name = "milesResultLabel";
            this.milesResultLabel.Size = new System.Drawing.Size(0, 13);
            this.milesResultLabel.TabIndex = 14;
            // 
            // mpgResultLabel
            // 
            this.mpgResultLabel.AutoSize = true;
            this.mpgResultLabel.Location = new System.Drawing.Point(168, 216);
            this.mpgResultLabel.Name = "mpgResultLabel";
            this.mpgResultLabel.Size = new System.Drawing.Size(0, 13);
            this.mpgResultLabel.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 261);
            this.Controls.Add(this.mpgResultLabel);
            this.Controls.Add(this.milesResultLabel);
            this.Controls.Add(this.totalCostResultLabel);
            this.Controls.Add(this.mpgLabel);
            this.Controls.Add(this.milesTraveledLabel);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.pricePerGallonLabel);
            this.Controls.Add(this.pricePerGallonTextBox);
            this.Controls.Add(this.gallonsFilledTextBox);
            this.Controls.Add(this.gallonsFilledLabel);
            this.Controls.Add(this.endingOdometerTextBox);
            this.Controls.Add(this.endingOdometerLabel);
            this.Controls.Add(this.beginningOdometerTextBox);
            this.Controls.Add(this.beginningOdometerLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label beginningOdometerLabel;
        private System.Windows.Forms.TextBox beginningOdometerTextBox;
        private System.Windows.Forms.Label endingOdometerLabel;
        private System.Windows.Forms.TextBox endingOdometerTextBox;
        private System.Windows.Forms.Label gallonsFilledLabel;
        private System.Windows.Forms.TextBox gallonsFilledTextBox;
        private System.Windows.Forms.TextBox pricePerGallonTextBox;
        private System.Windows.Forms.Label pricePerGallonLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label milesTraveledLabel;
        private System.Windows.Forms.Label mpgLabel;
        private System.Windows.Forms.Label totalCostResultLabel;
        private System.Windows.Forms.Label milesResultLabel;
        private System.Windows.Forms.Label mpgResultLabel;
    }
}

