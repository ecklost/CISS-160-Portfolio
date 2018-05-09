namespace DivisionDecVsMod___Eric_Klostermeyer
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
            this.dividendLabel = new System.Windows.Forms.Label();
            this.divisorLabel = new System.Windows.Forms.Label();
            this.dividendBox = new System.Windows.Forms.TextBox();
            this.divisorBox = new System.Windows.Forms.TextBox();
            this.dividedByLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.quotientLabel = new System.Windows.Forms.Label();
            this.remainderLabel = new System.Windows.Forms.Label();
            this.decimalAnswerLabel = new System.Windows.Forms.Label();
            this.quotientAnswerLabel = new System.Windows.Forms.Label();
            this.remainderAnswerLabel = new System.Windows.Forms.Label();
            this.decimalDivisionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dividendLabel
            // 
            this.dividendLabel.AutoSize = true;
            this.dividendLabel.Location = new System.Drawing.Point(20, 14);
            this.dividendLabel.Name = "dividendLabel";
            this.dividendLabel.Size = new System.Drawing.Size(49, 13);
            this.dividendLabel.TabIndex = 0;
            this.dividendLabel.Text = "Dividend";
            // 
            // divisorLabel
            // 
            this.divisorLabel.AutoSize = true;
            this.divisorLabel.Location = new System.Drawing.Point(154, 14);
            this.divisorLabel.Name = "divisorLabel";
            this.divisorLabel.Size = new System.Drawing.Size(39, 13);
            this.divisorLabel.TabIndex = 1;
            this.divisorLabel.Text = "Divisor";
            // 
            // dividendBox
            // 
            this.dividendBox.Location = new System.Drawing.Point(16, 30);
            this.dividendBox.Name = "dividendBox";
            this.dividendBox.Size = new System.Drawing.Size(57, 20);
            this.dividendBox.TabIndex = 2;
            // 
            // divisorBox
            // 
            this.divisorBox.Location = new System.Drawing.Point(145, 30);
            this.divisorBox.Name = "divisorBox";
            this.divisorBox.Size = new System.Drawing.Size(57, 20);
            this.divisorBox.TabIndex = 3;
            // 
            // dividedByLabel
            // 
            this.dividedByLabel.AutoSize = true;
            this.dividedByLabel.Location = new System.Drawing.Point(80, 33);
            this.dividedByLabel.Name = "dividedByLabel";
            this.dividedByLabel.Size = new System.Drawing.Size(58, 13);
            this.dividedByLabel.TabIndex = 4;
            this.dividedByLabel.Text = "Divided By";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(16, 67);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 5;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(127, 67);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(75, 23);
            this.clearAllButton.TabIndex = 6;
            this.clearAllButton.Text = "Clear All";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(16, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 2);
            this.label1.TabIndex = 7;
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.Location = new System.Drawing.Point(10, 104);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(198, 13);
            this.answerLabel.TabIndex = 8;
            this.answerLabel.Text = "Answer via Integer Division (Mod)";
            // 
            // quotientLabel
            // 
            this.quotientLabel.AutoSize = true;
            this.quotientLabel.Location = new System.Drawing.Point(23, 123);
            this.quotientLabel.Name = "quotientLabel";
            this.quotientLabel.Size = new System.Drawing.Size(50, 13);
            this.quotientLabel.TabIndex = 10;
            this.quotientLabel.Text = "Quotient:";
            // 
            // remainderLabel
            // 
            this.remainderLabel.AutoSize = true;
            this.remainderLabel.Location = new System.Drawing.Point(13, 148);
            this.remainderLabel.Name = "remainderLabel";
            this.remainderLabel.Size = new System.Drawing.Size(61, 13);
            this.remainderLabel.TabIndex = 11;
            this.remainderLabel.Text = "Remainder:";
            // 
            // decimalAnswerLabel
            // 
            this.decimalAnswerLabel.AutoSize = true;
            this.decimalAnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalAnswerLabel.Location = new System.Drawing.Point(23, 177);
            this.decimalAnswerLabel.Name = "decimalAnswerLabel";
            this.decimalAnswerLabel.Size = new System.Drawing.Size(167, 13);
            this.decimalAnswerLabel.TabIndex = 13;
            this.decimalAnswerLabel.Text = "Answer via Decimal Division";
            // 
            // quotientAnswerLabel
            // 
            this.quotientAnswerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quotientAnswerLabel.Location = new System.Drawing.Point(84, 121);
            this.quotientAnswerLabel.Name = "quotientAnswerLabel";
            this.quotientAnswerLabel.Size = new System.Drawing.Size(100, 21);
            this.quotientAnswerLabel.TabIndex = 14;
            // 
            // remainderAnswerLabel
            // 
            this.remainderAnswerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.remainderAnswerLabel.Location = new System.Drawing.Point(84, 147);
            this.remainderAnswerLabel.Name = "remainderAnswerLabel";
            this.remainderAnswerLabel.Size = new System.Drawing.Size(100, 21);
            this.remainderAnswerLabel.TabIndex = 15;
            // 
            // decimalDivisionLabel
            // 
            this.decimalDivisionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decimalDivisionLabel.Location = new System.Drawing.Point(54, 193);
            this.decimalDivisionLabel.Name = "decimalDivisionLabel";
            this.decimalDivisionLabel.Size = new System.Drawing.Size(100, 21);
            this.decimalDivisionLabel.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 261);
            this.Controls.Add(this.decimalDivisionLabel);
            this.Controls.Add(this.remainderAnswerLabel);
            this.Controls.Add(this.quotientAnswerLabel);
            this.Controls.Add(this.decimalAnswerLabel);
            this.Controls.Add(this.remainderLabel);
            this.Controls.Add(this.quotientLabel);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.dividedByLabel);
            this.Controls.Add(this.divisorBox);
            this.Controls.Add(this.dividendBox);
            this.Controls.Add(this.divisorLabel);
            this.Controls.Add(this.dividendLabel);
            this.Name = "Form1";
            this.Text = "Division in C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dividendLabel;
        private System.Windows.Forms.Label divisorLabel;
        private System.Windows.Forms.TextBox dividendBox;
        private System.Windows.Forms.TextBox divisorBox;
        private System.Windows.Forms.Label dividedByLabel;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Label quotientLabel;
        private System.Windows.Forms.Label remainderLabel;
        private System.Windows.Forms.Label decimalAnswerLabel;
        private System.Windows.Forms.Label quotientAnswerLabel;
        private System.Windows.Forms.Label remainderAnswerLabel;
        private System.Windows.Forms.Label decimalDivisionLabel;
    }
}

