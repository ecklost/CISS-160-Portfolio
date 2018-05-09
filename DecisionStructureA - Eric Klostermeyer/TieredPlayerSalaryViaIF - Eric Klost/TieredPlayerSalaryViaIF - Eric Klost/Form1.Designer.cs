namespace TieredPlayerSalaryViaIF___Eric_Klost
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
            this.playerLabel = new System.Windows.Forms.Label();
            this.hitsLabel = new System.Windows.Forms.Label();
            this.allStarCheckBox = new System.Windows.Forms.CheckBox();
            this.mvpCheckBox = new System.Windows.Forms.CheckBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.hitsTextBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.currentPlayerGroupBox = new System.Windows.Forms.GroupBox();
            this.resultFourLabel = new System.Windows.Forms.Label();
            this.resultThreeLabel = new System.Windows.Forms.Label();
            this.resultTwoLabel = new System.Windows.Forms.Label();
            this.resultOneLabel = new System.Windows.Forms.Label();
            this.currentPlayerSalaryLabel = new System.Windows.Forms.Label();
            this.currentPlayerSalaryGradeLabel = new System.Windows.Forms.Label();
            this.currentHitsLabel = new System.Windows.Forms.Label();
            this.currentNameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resultEightLabel = new System.Windows.Forms.Label();
            this.resultSevenLabel = new System.Windows.Forms.Label();
            this.resultSixLabel = new System.Windows.Forms.Label();
            this.resultFiveLabel = new System.Windows.Forms.Label();
            this.leaderSalaryLabel = new System.Windows.Forms.Label();
            this.leaderSalaryGradeLabel = new System.Windows.Forms.Label();
            this.leaderHitsLabel = new System.Windows.Forms.Label();
            this.leaderNameLabel = new System.Windows.Forms.Label();
            this.currentPlayerGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(12, 30);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(82, 13);
            this.playerLabel.TabIndex = 0;
            this.playerLabel.Text = "Name of Player:";
            // 
            // hitsLabel
            // 
            this.hitsLabel.AutoSize = true;
            this.hitsLabel.Location = new System.Drawing.Point(12, 65);
            this.hitsLabel.Name = "hitsLabel";
            this.hitsLabel.Size = new System.Drawing.Size(80, 13);
            this.hitsLabel.TabIndex = 1;
            this.hitsLabel.Text = "Number of Hits:";
            // 
            // allStarCheckBox
            // 
            this.allStarCheckBox.AutoSize = true;
            this.allStarCheckBox.Location = new System.Drawing.Point(12, 100);
            this.allStarCheckBox.Name = "allStarCheckBox";
            this.allStarCheckBox.Size = new System.Drawing.Size(113, 17);
            this.allStarCheckBox.TabIndex = 3;
            this.allStarCheckBox.Text = "Player was All-Star";
            this.allStarCheckBox.UseVisualStyleBackColor = true;
            // 
            // mvpCheckBox
            // 
            this.mvpCheckBox.AutoSize = true;
            this.mvpCheckBox.Location = new System.Drawing.Point(12, 120);
            this.mvpCheckBox.Name = "mvpCheckBox";
            this.mvpCheckBox.Size = new System.Drawing.Size(103, 17);
            this.mvpCheckBox.TabIndex = 4;
            this.mvpCheckBox.Text = "Player was MVP";
            this.mvpCheckBox.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(100, 27);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // hitsTextBox
            // 
            this.hitsTextBox.Location = new System.Drawing.Point(100, 62);
            this.hitsTextBox.Name = "hitsTextBox";
            this.hitsTextBox.Size = new System.Drawing.Size(100, 20);
            this.hitsTextBox.TabIndex = 6;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(224, 25);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 7;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(224, 60);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // currentPlayerGroupBox
            // 
            this.currentPlayerGroupBox.Controls.Add(this.resultFourLabel);
            this.currentPlayerGroupBox.Controls.Add(this.resultThreeLabel);
            this.currentPlayerGroupBox.Controls.Add(this.resultTwoLabel);
            this.currentPlayerGroupBox.Controls.Add(this.resultOneLabel);
            this.currentPlayerGroupBox.Controls.Add(this.currentPlayerSalaryLabel);
            this.currentPlayerGroupBox.Controls.Add(this.currentPlayerSalaryGradeLabel);
            this.currentPlayerGroupBox.Controls.Add(this.currentHitsLabel);
            this.currentPlayerGroupBox.Controls.Add(this.currentNameLabel);
            this.currentPlayerGroupBox.Location = new System.Drawing.Point(15, 156);
            this.currentPlayerGroupBox.Name = "currentPlayerGroupBox";
            this.currentPlayerGroupBox.Size = new System.Drawing.Size(284, 100);
            this.currentPlayerGroupBox.TabIndex = 9;
            this.currentPlayerGroupBox.TabStop = false;
            this.currentPlayerGroupBox.Text = "Current Player";
            // 
            // resultFourLabel
            // 
            this.resultFourLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.resultFourLabel.AutoSize = true;
            this.resultFourLabel.Location = new System.Drawing.Point(90, 80);
            this.resultFourLabel.Name = "resultFourLabel";
            this.resultFourLabel.Size = new System.Drawing.Size(46, 13);
            this.resultFourLabel.TabIndex = 15;
            this.resultFourLabel.Text = "Result 4";
            this.resultFourLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // resultThreeLabel
            // 
            this.resultThreeLabel.AutoSize = true;
            this.resultThreeLabel.Location = new System.Drawing.Point(90, 60);
            this.resultThreeLabel.Name = "resultThreeLabel";
            this.resultThreeLabel.Size = new System.Drawing.Size(46, 13);
            this.resultThreeLabel.TabIndex = 15;
            this.resultThreeLabel.Text = "Result 3";
            this.resultThreeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // resultTwoLabel
            // 
            this.resultTwoLabel.AutoSize = true;
            this.resultTwoLabel.Location = new System.Drawing.Point(90, 40);
            this.resultTwoLabel.Name = "resultTwoLabel";
            this.resultTwoLabel.Size = new System.Drawing.Size(46, 13);
            this.resultTwoLabel.TabIndex = 15;
            this.resultTwoLabel.Text = "Result 2";
            this.resultTwoLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // resultOneLabel
            // 
            this.resultOneLabel.AutoSize = true;
            this.resultOneLabel.Location = new System.Drawing.Point(90, 20);
            this.resultOneLabel.Name = "resultOneLabel";
            this.resultOneLabel.Size = new System.Drawing.Size(46, 13);
            this.resultOneLabel.TabIndex = 14;
            this.resultOneLabel.Text = "Result 1";
            this.resultOneLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // currentPlayerSalaryLabel
            // 
            this.currentPlayerSalaryLabel.AutoSize = true;
            this.currentPlayerSalaryLabel.Location = new System.Drawing.Point(7, 80);
            this.currentPlayerSalaryLabel.Name = "currentPlayerSalaryLabel";
            this.currentPlayerSalaryLabel.Size = new System.Drawing.Size(39, 13);
            this.currentPlayerSalaryLabel.TabIndex = 13;
            this.currentPlayerSalaryLabel.Text = "Salary:";
            // 
            // currentPlayerSalaryGradeLabel
            // 
            this.currentPlayerSalaryGradeLabel.AutoSize = true;
            this.currentPlayerSalaryGradeLabel.Location = new System.Drawing.Point(7, 60);
            this.currentPlayerSalaryGradeLabel.Name = "currentPlayerSalaryGradeLabel";
            this.currentPlayerSalaryGradeLabel.Size = new System.Drawing.Size(71, 13);
            this.currentPlayerSalaryGradeLabel.TabIndex = 12;
            this.currentPlayerSalaryGradeLabel.Text = "Salary Grade:";
            this.currentPlayerSalaryGradeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // currentHitsLabel
            // 
            this.currentHitsLabel.AutoSize = true;
            this.currentHitsLabel.Location = new System.Drawing.Point(7, 40);
            this.currentHitsLabel.Name = "currentHitsLabel";
            this.currentHitsLabel.Size = new System.Drawing.Size(28, 13);
            this.currentHitsLabel.TabIndex = 11;
            this.currentHitsLabel.Text = "Hits:";
            this.currentHitsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // currentNameLabel
            // 
            this.currentNameLabel.AutoSize = true;
            this.currentNameLabel.Location = new System.Drawing.Point(7, 20);
            this.currentNameLabel.Name = "currentNameLabel";
            this.currentNameLabel.Size = new System.Drawing.Size(70, 13);
            this.currentNameLabel.TabIndex = 0;
            this.currentNameLabel.Text = "Player Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resultEightLabel);
            this.groupBox1.Controls.Add(this.resultSevenLabel);
            this.groupBox1.Controls.Add(this.resultSixLabel);
            this.groupBox1.Controls.Add(this.resultFiveLabel);
            this.groupBox1.Controls.Add(this.leaderSalaryLabel);
            this.groupBox1.Controls.Add(this.leaderSalaryGradeLabel);
            this.groupBox1.Controls.Add(this.leaderHitsLabel);
            this.groupBox1.Controls.Add(this.leaderNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(15, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current  Leader";
            // 
            // resultEightLabel
            // 
            this.resultEightLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.resultEightLabel.AutoSize = true;
            this.resultEightLabel.Location = new System.Drawing.Point(90, 80);
            this.resultEightLabel.Name = "resultEightLabel";
            this.resultEightLabel.Size = new System.Drawing.Size(46, 13);
            this.resultEightLabel.TabIndex = 15;
            this.resultEightLabel.Text = "Result 8";
            this.resultEightLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // resultSevenLabel
            // 
            this.resultSevenLabel.AutoSize = true;
            this.resultSevenLabel.Location = new System.Drawing.Point(90, 60);
            this.resultSevenLabel.Name = "resultSevenLabel";
            this.resultSevenLabel.Size = new System.Drawing.Size(46, 13);
            this.resultSevenLabel.TabIndex = 15;
            this.resultSevenLabel.Text = "Result 7";
            this.resultSevenLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // resultSixLabel
            // 
            this.resultSixLabel.AutoSize = true;
            this.resultSixLabel.Location = new System.Drawing.Point(90, 40);
            this.resultSixLabel.Name = "resultSixLabel";
            this.resultSixLabel.Size = new System.Drawing.Size(46, 13);
            this.resultSixLabel.TabIndex = 15;
            this.resultSixLabel.Text = "Result 6";
            this.resultSixLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // resultFiveLabel
            // 
            this.resultFiveLabel.AutoSize = true;
            this.resultFiveLabel.Location = new System.Drawing.Point(90, 20);
            this.resultFiveLabel.Name = "resultFiveLabel";
            this.resultFiveLabel.Size = new System.Drawing.Size(46, 13);
            this.resultFiveLabel.TabIndex = 14;
            this.resultFiveLabel.Text = "Result 5";
            this.resultFiveLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // leaderSalaryLabel
            // 
            this.leaderSalaryLabel.AutoSize = true;
            this.leaderSalaryLabel.Location = new System.Drawing.Point(7, 80);
            this.leaderSalaryLabel.Name = "leaderSalaryLabel";
            this.leaderSalaryLabel.Size = new System.Drawing.Size(39, 13);
            this.leaderSalaryLabel.TabIndex = 13;
            this.leaderSalaryLabel.Text = "Salary:";
            // 
            // leaderSalaryGradeLabel
            // 
            this.leaderSalaryGradeLabel.AutoSize = true;
            this.leaderSalaryGradeLabel.Location = new System.Drawing.Point(7, 60);
            this.leaderSalaryGradeLabel.Name = "leaderSalaryGradeLabel";
            this.leaderSalaryGradeLabel.Size = new System.Drawing.Size(71, 13);
            this.leaderSalaryGradeLabel.TabIndex = 12;
            this.leaderSalaryGradeLabel.Text = "Salary Grade:";
            this.leaderSalaryGradeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // leaderHitsLabel
            // 
            this.leaderHitsLabel.AutoSize = true;
            this.leaderHitsLabel.Location = new System.Drawing.Point(7, 40);
            this.leaderHitsLabel.Name = "leaderHitsLabel";
            this.leaderHitsLabel.Size = new System.Drawing.Size(28, 13);
            this.leaderHitsLabel.TabIndex = 11;
            this.leaderHitsLabel.Text = "Hits:";
            this.leaderHitsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // leaderNameLabel
            // 
            this.leaderNameLabel.AutoSize = true;
            this.leaderNameLabel.Location = new System.Drawing.Point(7, 20);
            this.leaderNameLabel.Name = "leaderNameLabel";
            this.leaderNameLabel.Size = new System.Drawing.Size(70, 13);
            this.leaderNameLabel.TabIndex = 0;
            this.leaderNameLabel.Text = "Player Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 388);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.currentPlayerGroupBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.hitsTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.mvpCheckBox);
            this.Controls.Add(this.allStarCheckBox);
            this.Controls.Add(this.hitsLabel);
            this.Controls.Add(this.playerLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.currentPlayerGroupBox.ResumeLayout(false);
            this.currentPlayerGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label hitsLabel;
        private System.Windows.Forms.CheckBox allStarCheckBox;
        private System.Windows.Forms.CheckBox mvpCheckBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox hitsTextBox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox currentPlayerGroupBox;
        private System.Windows.Forms.Label currentHitsLabel;
        private System.Windows.Forms.Label currentNameLabel;
        private System.Windows.Forms.Label currentPlayerSalaryLabel;
        private System.Windows.Forms.Label currentPlayerSalaryGradeLabel;
        private System.Windows.Forms.Label resultTwoLabel;
        private System.Windows.Forms.Label resultOneLabel;
        private System.Windows.Forms.Label resultFourLabel;
        private System.Windows.Forms.Label resultThreeLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label resultEightLabel;
        private System.Windows.Forms.Label resultSevenLabel;
        private System.Windows.Forms.Label resultSixLabel;
        private System.Windows.Forms.Label resultFiveLabel;
        private System.Windows.Forms.Label leaderSalaryLabel;
        private System.Windows.Forms.Label leaderSalaryGradeLabel;
        private System.Windows.Forms.Label leaderHitsLabel;
        private System.Windows.Forms.Label leaderNameLabel;
    }
}

