namespace WindowsFormsApplication3
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
            this.enterWinningLabel = new System.Windows.Forms.Label();
            this.numberOneBox = new System.Windows.Forms.TextBox();
            this.numberTwoBox = new System.Windows.Forms.TextBox();
            this.numberThreeBox = new System.Windows.Forms.TextBox();
            this.luckyButton = new System.Windows.Forms.Button();
            this.generatedNumberLabel = new System.Windows.Forms.Label();
            this.generatedNumOneBox = new System.Windows.Forms.TextBox();
            this.generatedNumTwoBox = new System.Windows.Forms.TextBox();
            this.generatedNumThreeBox = new System.Windows.Forms.TextBox();
            this.attemptsLabel = new System.Windows.Forms.Label();
            this.attemptsBox = new System.Windows.Forms.TextBox();
            this.prizeLabel = new System.Windows.Forms.Label();
            this.prizeBox = new System.Windows.Forms.TextBox();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterWinningLabel
            // 
            this.enterWinningLabel.AutoSize = true;
            this.enterWinningLabel.Location = new System.Drawing.Point(22, 24);
            this.enterWinningLabel.Name = "enterWinningLabel";
            this.enterWinningLabel.Size = new System.Drawing.Size(135, 13);
            this.enterWinningLabel.TabIndex = 0;
            this.enterWinningLabel.Text = "Enter the Winning Number:";
            // 
            // numberOneBox
            // 
            this.numberOneBox.Location = new System.Drawing.Point(223, 21);
            this.numberOneBox.Name = "numberOneBox";
            this.numberOneBox.Size = new System.Drawing.Size(25, 20);
            this.numberOneBox.TabIndex = 1;
            this.numberOneBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numberTwoBox
            // 
            this.numberTwoBox.Location = new System.Drawing.Point(269, 21);
            this.numberTwoBox.Name = "numberTwoBox";
            this.numberTwoBox.Size = new System.Drawing.Size(25, 20);
            this.numberTwoBox.TabIndex = 2;
            this.numberTwoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numberThreeBox
            // 
            this.numberThreeBox.Location = new System.Drawing.Point(314, 21);
            this.numberThreeBox.Name = "numberThreeBox";
            this.numberThreeBox.Size = new System.Drawing.Size(25, 20);
            this.numberThreeBox.TabIndex = 3;
            this.numberThreeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // luckyButton
            // 
            this.luckyButton.Location = new System.Drawing.Point(12, 55);
            this.luckyButton.Name = "luckyButton";
            this.luckyButton.Size = new System.Drawing.Size(338, 23);
            this.luckyButton.TabIndex = 4;
            this.luckyButton.Text = "I\'m Feeling Lucky";
            this.luckyButton.UseVisualStyleBackColor = true;
            this.luckyButton.Click += new System.EventHandler(this.luckyButton_Click);
            // 
            // generatedNumberLabel
            // 
            this.generatedNumberLabel.AutoSize = true;
            this.generatedNumberLabel.Location = new System.Drawing.Point(25, 94);
            this.generatedNumberLabel.Name = "generatedNumberLabel";
            this.generatedNumberLabel.Size = new System.Drawing.Size(146, 13);
            this.generatedNumberLabel.TabIndex = 5;
            this.generatedNumberLabel.Text = "Generated Random Number: ";
            // 
            // generatedNumOneBox
            // 
            this.generatedNumOneBox.Enabled = false;
            this.generatedNumOneBox.Location = new System.Drawing.Point(223, 91);
            this.generatedNumOneBox.Name = "generatedNumOneBox";
            this.generatedNumOneBox.Size = new System.Drawing.Size(25, 20);
            this.generatedNumOneBox.TabIndex = 6;
            this.generatedNumOneBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // generatedNumTwoBox
            // 
            this.generatedNumTwoBox.Enabled = false;
            this.generatedNumTwoBox.Location = new System.Drawing.Point(269, 91);
            this.generatedNumTwoBox.Name = "generatedNumTwoBox";
            this.generatedNumTwoBox.Size = new System.Drawing.Size(25, 20);
            this.generatedNumTwoBox.TabIndex = 7;
            this.generatedNumTwoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // generatedNumThreeBox
            // 
            this.generatedNumThreeBox.Enabled = false;
            this.generatedNumThreeBox.Location = new System.Drawing.Point(314, 91);
            this.generatedNumThreeBox.Name = "generatedNumThreeBox";
            this.generatedNumThreeBox.Size = new System.Drawing.Size(25, 20);
            this.generatedNumThreeBox.TabIndex = 8;
            this.generatedNumThreeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // attemptsLabel
            // 
            this.attemptsLabel.AutoSize = true;
            this.attemptsLabel.Location = new System.Drawing.Point(25, 128);
            this.attemptsLabel.Name = "attemptsLabel";
            this.attemptsLabel.Size = new System.Drawing.Size(106, 13);
            this.attemptsLabel.TabIndex = 9;
            this.attemptsLabel.Text = "Number of Attempts: ";
            // 
            // attemptsBox
            // 
            this.attemptsBox.Enabled = false;
            this.attemptsBox.Location = new System.Drawing.Point(269, 125);
            this.attemptsBox.Name = "attemptsBox";
            this.attemptsBox.Size = new System.Drawing.Size(70, 20);
            this.attemptsBox.TabIndex = 10;
            this.attemptsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // prizeLabel
            // 
            this.prizeLabel.AutoSize = true;
            this.prizeLabel.Location = new System.Drawing.Point(25, 162);
            this.prizeLabel.Name = "prizeLabel";
            this.prizeLabel.Size = new System.Drawing.Size(123, 13);
            this.prizeLabel.TabIndex = 11;
            this.prizeLabel.Text = "Matching Number Pays: ";
            // 
            // prizeBox
            // 
            this.prizeBox.Enabled = false;
            this.prizeBox.Location = new System.Drawing.Point(269, 159);
            this.prizeBox.Name = "prizeBox";
            this.prizeBox.Size = new System.Drawing.Size(70, 20);
            this.prizeBox.TabIndex = 12;
            this.prizeBox.Text = "$500";
            this.prizeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // resultsListBox
            // 
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.Location = new System.Drawing.Point(25, 200);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(314, 238);
            this.resultsListBox.TabIndex = 13;
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(12, 447);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(338, 23);
            this.clearAllButton.TabIndex = 14;
            this.clearAllButton.Text = "Clear All";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 482);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.resultsListBox);
            this.Controls.Add(this.prizeBox);
            this.Controls.Add(this.prizeLabel);
            this.Controls.Add(this.attemptsBox);
            this.Controls.Add(this.attemptsLabel);
            this.Controls.Add(this.generatedNumThreeBox);
            this.Controls.Add(this.generatedNumTwoBox);
            this.Controls.Add(this.generatedNumOneBox);
            this.Controls.Add(this.generatedNumberLabel);
            this.Controls.Add(this.luckyButton);
            this.Controls.Add(this.numberThreeBox);
            this.Controls.Add(this.numberTwoBox);
            this.Controls.Add(this.numberOneBox);
            this.Controls.Add(this.enterWinningLabel);
            this.Name = "Form1";
            this.Text = "Lottery - Odds Are...";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterWinningLabel;
        private System.Windows.Forms.TextBox numberOneBox;
        private System.Windows.Forms.TextBox numberTwoBox;
        private System.Windows.Forms.TextBox numberThreeBox;
        private System.Windows.Forms.Button luckyButton;
        private System.Windows.Forms.Label generatedNumberLabel;
        private System.Windows.Forms.TextBox generatedNumOneBox;
        private System.Windows.Forms.TextBox generatedNumTwoBox;
        private System.Windows.Forms.TextBox generatedNumThreeBox;
        private System.Windows.Forms.Label attemptsLabel;
        private System.Windows.Forms.TextBox attemptsBox;
        private System.Windows.Forms.Label prizeLabel;
        private System.Windows.Forms.TextBox prizeBox;
        private System.Windows.Forms.ListBox resultsListBox;
        private System.Windows.Forms.Button clearAllButton;
    }
}

