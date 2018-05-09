namespace UIControlsAndMultiLine___Eric_Klost
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
            this.descLabel = new System.Windows.Forms.Label();
            this.chooseCarGroupBox = new System.Windows.Forms.GroupBox();
            this.soulRadioButton = new System.Windows.Forms.RadioButton();
            this.mazdaRadioButton = new System.Windows.Forms.RadioButton();
            this.optionsGroupBox = new System.Windows.Forms.GroupBox();
            this.sunRoofCheckBox = new System.Windows.Forms.CheckBox();
            this.entertainmentCheckBox = new System.Windows.Forms.CheckBox();
            this.racingPackageCheckBox = new System.Windows.Forms.CheckBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.whatYouOrderedLabel = new System.Windows.Forms.Label();
            this.orderedLabel = new System.Windows.Forms.Label();
            this.chooseCarGroupBox.SuspendLayout();
            this.optionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(13, 13);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(603, 13);
            this.descLabel.TabIndex = 0;
            this.descLabel.Text = "This form is meant to show the Total Cost of a selected Car and selected options." +
    " It will also display text from what was chosen.";
            // 
            // chooseCarGroupBox
            // 
            this.chooseCarGroupBox.Controls.Add(this.mazdaRadioButton);
            this.chooseCarGroupBox.Controls.Add(this.soulRadioButton);
            this.chooseCarGroupBox.Location = new System.Drawing.Point(16, 41);
            this.chooseCarGroupBox.Name = "chooseCarGroupBox";
            this.chooseCarGroupBox.Size = new System.Drawing.Size(210, 73);
            this.chooseCarGroupBox.TabIndex = 1;
            this.chooseCarGroupBox.TabStop = false;
            this.chooseCarGroupBox.Text = "Select One Car to Buy";
            // 
            // soulRadioButton
            // 
            this.soulRadioButton.AutoSize = true;
            this.soulRadioButton.Location = new System.Drawing.Point(19, 19);
            this.soulRadioButton.Name = "soulRadioButton";
            this.soulRadioButton.Size = new System.Drawing.Size(139, 17);
            this.soulRadioButton.TabIndex = 0;
            this.soulRadioButton.TabStop = true;
            this.soulRadioButton.Text = "2015 Kia Soul ($15,000)";
            this.soulRadioButton.UseVisualStyleBackColor = true;
            // 
            // mazdaRadioButton
            // 
            this.mazdaRadioButton.AutoSize = true;
            this.mazdaRadioButton.Location = new System.Drawing.Point(19, 43);
            this.mazdaRadioButton.Name = "mazdaRadioButton";
            this.mazdaRadioButton.Size = new System.Drawing.Size(141, 17);
            this.mazdaRadioButton.TabIndex = 1;
            this.mazdaRadioButton.TabStop = true;
            this.mazdaRadioButton.Text = "2016 Mazda 3 ($17,000)";
            this.mazdaRadioButton.UseVisualStyleBackColor = true;
            // 
            // optionsGroupBox
            // 
            this.optionsGroupBox.Controls.Add(this.racingPackageCheckBox);
            this.optionsGroupBox.Controls.Add(this.entertainmentCheckBox);
            this.optionsGroupBox.Controls.Add(this.sunRoofCheckBox);
            this.optionsGroupBox.Location = new System.Drawing.Point(16, 121);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Size = new System.Drawing.Size(210, 100);
            this.optionsGroupBox.TabIndex = 2;
            this.optionsGroupBox.TabStop = false;
            this.optionsGroupBox.Text = "Choose One or More Optional Features";
            // 
            // sunRoofCheckBox
            // 
            this.sunRoofCheckBox.AutoSize = true;
            this.sunRoofCheckBox.Location = new System.Drawing.Point(19, 20);
            this.sunRoofCheckBox.Name = "sunRoofCheckBox";
            this.sunRoofCheckBox.Size = new System.Drawing.Size(113, 17);
            this.sunRoofCheckBox.TabIndex = 0;
            this.sunRoofCheckBox.Text = "Sun Roof ($1,000)";
            this.sunRoofCheckBox.UseVisualStyleBackColor = true;
            // 
            // entertainmentCheckBox
            // 
            this.entertainmentCheckBox.AutoSize = true;
            this.entertainmentCheckBox.Location = new System.Drawing.Point(19, 44);
            this.entertainmentCheckBox.Name = "entertainmentCheckBox";
            this.entertainmentCheckBox.Size = new System.Drawing.Size(179, 17);
            this.entertainmentCheckBox.TabIndex = 1;
            this.entertainmentCheckBox.Text = "Entertainment Package ($1,500)";
            this.entertainmentCheckBox.UseVisualStyleBackColor = true;
            // 
            // racingPackageCheckBox
            // 
            this.racingPackageCheckBox.AutoSize = true;
            this.racingPackageCheckBox.Location = new System.Drawing.Point(19, 68);
            this.racingPackageCheckBox.Name = "racingPackageCheckBox";
            this.racingPackageCheckBox.Size = new System.Drawing.Size(139, 17);
            this.racingPackageCheckBox.TabIndex = 2;
            this.racingPackageCheckBox.Text = "Racing Package ($500)";
            this.racingPackageCheckBox.UseVisualStyleBackColor = true;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(315, 41);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 3;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(448, 41);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear All";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(272, 84);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(152, 13);
            this.totalCostLabel.TabIndex = 5;
            this.totalCostLabel.Text = "Total Cost of Car and Options: ";
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultLabel.Location = new System.Drawing.Point(430, 78);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(121, 23);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // whatYouOrderedLabel
            // 
            this.whatYouOrderedLabel.AutoSize = true;
            this.whatYouOrderedLabel.Location = new System.Drawing.Point(275, 110);
            this.whatYouOrderedLabel.Name = "whatYouOrderedLabel";
            this.whatYouOrderedLabel.Size = new System.Drawing.Size(99, 13);
            this.whatYouOrderedLabel.TabIndex = 7;
            this.whatYouOrderedLabel.Text = "What You Ordered:";
            // 
            // orderedLabel
            // 
            this.orderedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orderedLabel.Location = new System.Drawing.Point(275, 127);
            this.orderedLabel.Name = "orderedLabel";
            this.orderedLabel.Size = new System.Drawing.Size(276, 94);
            this.orderedLabel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 229);
            this.Controls.Add(this.orderedLabel);
            this.Controls.Add(this.whatYouOrderedLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.optionsGroupBox);
            this.Controls.Add(this.chooseCarGroupBox);
            this.Controls.Add(this.descLabel);
            this.Name = "Form1";
            this.Text = "User Interface Controls";
            this.chooseCarGroupBox.ResumeLayout(false);
            this.chooseCarGroupBox.PerformLayout();
            this.optionsGroupBox.ResumeLayout(false);
            this.optionsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.GroupBox chooseCarGroupBox;
        private System.Windows.Forms.RadioButton mazdaRadioButton;
        private System.Windows.Forms.RadioButton soulRadioButton;
        private System.Windows.Forms.GroupBox optionsGroupBox;
        private System.Windows.Forms.CheckBox racingPackageCheckBox;
        private System.Windows.Forms.CheckBox entertainmentCheckBox;
        private System.Windows.Forms.CheckBox sunRoofCheckBox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label whatYouOrderedLabel;
        private System.Windows.Forms.Label orderedLabel;
    }
}

