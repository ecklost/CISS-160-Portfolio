namespace MultiAndAccum___Eric_Klostermeyer
{
    partial class CH1to4Summary
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
            this.goalLabel = new System.Windows.Forms.Label();
            this.numberOneLabel = new System.Windows.Forms.Label();
            this.numberTwoLabel = new System.Windows.Forms.Label();
            this.timesLabel = new System.Windows.Forms.Label();
            this.numberOneBox = new System.Windows.Forms.TextBox();
            this.equalsLabel = new System.Windows.Forms.Label();
            this.numberTwoBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.actualResultsLabel = new System.Windows.Forms.Label();
            this.allTotalsLabel = new System.Windows.Forms.Label();
            this.runningTotalLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goalLabel
            // 
            this.goalLabel.Location = new System.Drawing.Point(13, 13);
            this.goalLabel.Name = "goalLabel";
            this.goalLabel.Size = new System.Drawing.Size(611, 26);
            this.goalLabel.TabIndex = 0;
            this.goalLabel.Text = "This Form will multiply the numbers entered into each of the two Text Boxes and d" +
    "isplay the Result in the Label below. It will also accumulate the Results.";
            // 
            // numberOneLabel
            // 
            this.numberOneLabel.AutoSize = true;
            this.numberOneLabel.Location = new System.Drawing.Point(87, 84);
            this.numberOneLabel.Name = "numberOneLabel";
            this.numberOneLabel.Size = new System.Drawing.Size(56, 13);
            this.numberOneLabel.TabIndex = 1;
            this.numberOneLabel.Text = "Number 1:";
            // 
            // numberTwoLabel
            // 
            this.numberTwoLabel.AutoSize = true;
            this.numberTwoLabel.Location = new System.Drawing.Point(214, 84);
            this.numberTwoLabel.Name = "numberTwoLabel";
            this.numberTwoLabel.Size = new System.Drawing.Size(56, 13);
            this.numberTwoLabel.TabIndex = 2;
            this.numberTwoLabel.Text = "Number 2:";
            // 
            // timesLabel
            // 
            this.timesLabel.AutoSize = true;
            this.timesLabel.Location = new System.Drawing.Point(171, 109);
            this.timesLabel.Name = "timesLabel";
            this.timesLabel.Size = new System.Drawing.Size(12, 13);
            this.timesLabel.TabIndex = 3;
            this.timesLabel.Text = "x";
            // 
            // numberOneBox
            // 
            this.numberOneBox.Location = new System.Drawing.Point(65, 105);
            this.numberOneBox.Name = "numberOneBox";
            this.numberOneBox.Size = new System.Drawing.Size(100, 20);
            this.numberOneBox.TabIndex = 4;
            // 
            // equalsLabel
            // 
            this.equalsLabel.AutoSize = true;
            this.equalsLabel.Location = new System.Drawing.Point(295, 109);
            this.equalsLabel.Name = "equalsLabel";
            this.equalsLabel.Size = new System.Drawing.Size(13, 13);
            this.equalsLabel.TabIndex = 5;
            this.equalsLabel.Text = "=";
            // 
            // numberTwoBox
            // 
            this.numberTwoBox.Location = new System.Drawing.Point(189, 105);
            this.numberTwoBox.Name = "numberTwoBox";
            this.numberTwoBox.Size = new System.Drawing.Size(100, 20);
            this.numberTwoBox.TabIndex = 6;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(344, 84);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(40, 13);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "Result:";
            // 
            // actualResultsLabel
            // 
            this.actualResultsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.actualResultsLabel.Location = new System.Drawing.Point(314, 105);
            this.actualResultsLabel.Name = "actualResultsLabel";
            this.actualResultsLabel.Size = new System.Drawing.Size(100, 20);
            this.actualResultsLabel.TabIndex = 8;
            this.actualResultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // allTotalsLabel
            // 
            this.allTotalsLabel.Location = new System.Drawing.Point(456, 69);
            this.allTotalsLabel.Name = "allTotalsLabel";
            this.allTotalsLabel.Size = new System.Drawing.Size(100, 28);
            this.allTotalsLabel.TabIndex = 9;
            this.allTotalsLabel.Text = "Running Total of Results so far:";
            // 
            // runningTotalLabel
            // 
            this.runningTotalLabel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.runningTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.runningTotalLabel.Location = new System.Drawing.Point(449, 105);
            this.runningTotalLabel.Name = "runningTotalLabel";
            this.runningTotalLabel.Size = new System.Drawing.Size(100, 20);
            this.runningTotalLabel.TabIndex = 10;
            this.runningTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(189, 150);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 11;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(339, 150);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(75, 23);
            this.clearAllButton.TabIndex = 12;
            this.clearAllButton.Text = "Clear All";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // CH1to4Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 193);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.runningTotalLabel);
            this.Controls.Add(this.allTotalsLabel);
            this.Controls.Add(this.actualResultsLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.numberTwoBox);
            this.Controls.Add(this.equalsLabel);
            this.Controls.Add(this.numberOneBox);
            this.Controls.Add(this.timesLabel);
            this.Controls.Add(this.numberTwoLabel);
            this.Controls.Add(this.numberOneLabel);
            this.Controls.Add(this.goalLabel);
            this.Name = "CH1to4Summary";
            this.Text = "Chapters 1 - 4 Summary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label goalLabel;
        private System.Windows.Forms.Label numberOneLabel;
        private System.Windows.Forms.Label numberTwoLabel;
        private System.Windows.Forms.Label timesLabel;
        private System.Windows.Forms.TextBox numberOneBox;
        private System.Windows.Forms.Label equalsLabel;
        private System.Windows.Forms.TextBox numberTwoBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label actualResultsLabel;
        private System.Windows.Forms.Label allTotalsLabel;
        private System.Windows.Forms.Label runningTotalLabel;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearAllButton;
    }
}

