namespace MathLibCircleInfo___Eric_Klostermeyer
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
            this.radiusLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.radiusEntryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.diameterLabel = new System.Windows.Forms.Label();
            this.circumferenceLabel = new System.Windows.Forms.Label();
            this.areaLabel = new System.Windows.Forms.Label();
            this.diameterResultBox = new System.Windows.Forms.TextBox();
            this.circumferenceResultBox = new System.Windows.Forms.TextBox();
            this.areaResultBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Location = new System.Drawing.Point(13, 13);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(105, 13);
            this.radiusLabel.TabIndex = 0;
            this.radiusLabel.Text = "Radius of the Circle: ";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(84, 36);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 1;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // radiusEntryTextBox
            // 
            this.radiusEntryTextBox.Location = new System.Drawing.Point(124, 10);
            this.radiusEntryTextBox.Name = "radiusEntryTextBox";
            this.radiusEntryTextBox.Size = new System.Drawing.Size(100, 20);
            this.radiusEntryTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(11, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 2);
            this.label1.TabIndex = 3;
            // 
            // diameterLabel
            // 
            this.diameterLabel.AutoSize = true;
            this.diameterLabel.Location = new System.Drawing.Point(16, 82);
            this.diameterLabel.Name = "diameterLabel";
            this.diameterLabel.Size = new System.Drawing.Size(55, 13);
            this.diameterLabel.TabIndex = 4;
            this.diameterLabel.Text = "Diameter: ";
            // 
            // circumferenceLabel
            // 
            this.circumferenceLabel.AutoSize = true;
            this.circumferenceLabel.Location = new System.Drawing.Point(16, 126);
            this.circumferenceLabel.Name = "circumferenceLabel";
            this.circumferenceLabel.Size = new System.Drawing.Size(78, 13);
            this.circumferenceLabel.TabIndex = 5;
            this.circumferenceLabel.Text = "Circumference:";
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Location = new System.Drawing.Point(16, 168);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(35, 13);
            this.areaLabel.TabIndex = 6;
            this.areaLabel.Text = "Area: ";
            // 
            // diameterResultBox
            // 
            this.diameterResultBox.Enabled = false;
            this.diameterResultBox.Location = new System.Drawing.Point(124, 79);
            this.diameterResultBox.Name = "diameterResultBox";
            this.diameterResultBox.Size = new System.Drawing.Size(100, 20);
            this.diameterResultBox.TabIndex = 7;
            // 
            // circumferenceResultBox
            // 
            this.circumferenceResultBox.Enabled = false;
            this.circumferenceResultBox.Location = new System.Drawing.Point(124, 123);
            this.circumferenceResultBox.Name = "circumferenceResultBox";
            this.circumferenceResultBox.Size = new System.Drawing.Size(100, 20);
            this.circumferenceResultBox.TabIndex = 8;
            // 
            // areaResultBox
            // 
            this.areaResultBox.Enabled = false;
            this.areaResultBox.Location = new System.Drawing.Point(124, 165);
            this.areaResultBox.Name = "areaResultBox";
            this.areaResultBox.Size = new System.Drawing.Size(100, 20);
            this.areaResultBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 200);
            this.Controls.Add(this.areaResultBox);
            this.Controls.Add(this.circumferenceResultBox);
            this.Controls.Add(this.diameterResultBox);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.circumferenceLabel);
            this.Controls.Add(this.diameterLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radiusEntryTextBox);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.radiusLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.TextBox radiusEntryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label diameterLabel;
        private System.Windows.Forms.Label circumferenceLabel;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.TextBox diameterResultBox;
        private System.Windows.Forms.TextBox circumferenceResultBox;
        private System.Windows.Forms.TextBox areaResultBox;
    }
}

