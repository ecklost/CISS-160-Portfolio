namespace ShippingCalculator
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
            this.weightLabel = new System.Windows.Forms.Label();
            this.letterCodeLabel = new System.Windows.Forms.Label();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.letterCodeBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.cappedLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.zoneCostLabel = new System.Windows.Forms.Label();
            this.weightCostLabel = new System.Windows.Forms.Label();
            this.outputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(13, 13);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(115, 13);
            this.weightLabel.TabIndex = 0;
            this.weightLabel.Text = "Packaging Weight (lb):";
            // 
            // letterCodeLabel
            // 
            this.letterCodeLabel.AutoSize = true;
            this.letterCodeLabel.Location = new System.Drawing.Point(12, 43);
            this.letterCodeLabel.Name = "letterCodeLabel";
            this.letterCodeLabel.Size = new System.Drawing.Size(107, 13);
            this.letterCodeLabel.TabIndex = 1;
            this.letterCodeLabel.Text = "Letter Code (A, B, C):";
            // 
            // weightBox
            // 
            this.weightBox.Location = new System.Drawing.Point(134, 10);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(100, 20);
            this.weightBox.TabIndex = 2;
            // 
            // letterCodeBox
            // 
            this.letterCodeBox.Location = new System.Drawing.Point(134, 40);
            this.letterCodeBox.Name = "letterCodeBox";
            this.letterCodeBox.Size = new System.Drawing.Size(100, 20);
            this.letterCodeBox.TabIndex = 3;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(16, 80);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 4;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Controls.Add(this.cappedLabel);
            this.outputGroupBox.Controls.Add(this.totalCostLabel);
            this.outputGroupBox.Controls.Add(this.zoneCostLabel);
            this.outputGroupBox.Controls.Add(this.weightCostLabel);
            this.outputGroupBox.Location = new System.Drawing.Point(12, 123);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Size = new System.Drawing.Size(256, 126);
            this.outputGroupBox.TabIndex = 5;
            this.outputGroupBox.TabStop = false;
            this.outputGroupBox.Text = "Output";
            // 
            // cappedLabel
            // 
            this.cappedLabel.AutoSize = true;
            this.cappedLabel.Location = new System.Drawing.Point(102, 99);
            this.cappedLabel.Name = "cappedLabel";
            this.cappedLabel.Size = new System.Drawing.Size(50, 13);
            this.cappedLabel.TabIndex = 3;
            this.cappedLabel.Text = "CAPPED";
            this.cappedLabel.Visible = false;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(7, 60);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(61, 13);
            this.totalCostLabel.TabIndex = 2;
            this.totalCostLabel.Text = "Total Cost: ";
            // 
            // zoneCostLabel
            // 
            this.zoneCostLabel.AutoSize = true;
            this.zoneCostLabel.Location = new System.Drawing.Point(7, 40);
            this.zoneCostLabel.Name = "zoneCostLabel";
            this.zoneCostLabel.Size = new System.Drawing.Size(62, 13);
            this.zoneCostLabel.TabIndex = 1;
            this.zoneCostLabel.Text = "Zone Cost: ";
            // 
            // weightCostLabel
            // 
            this.weightCostLabel.AutoSize = true;
            this.weightCostLabel.Location = new System.Drawing.Point(7, 20);
            this.weightCostLabel.Name = "weightCostLabel";
            this.weightCostLabel.Size = new System.Drawing.Size(71, 13);
            this.weightCostLabel.TabIndex = 0;
            this.weightCostLabel.Text = "Weight Cost: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 261);
            this.Controls.Add(this.outputGroupBox);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.letterCodeBox);
            this.Controls.Add(this.weightBox);
            this.Controls.Add(this.letterCodeLabel);
            this.Controls.Add(this.weightLabel);
            this.Name = "Form1";
            this.Text = "Shipping Calculator";
            this.outputGroupBox.ResumeLayout(false);
            this.outputGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label letterCodeLabel;
        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.TextBox letterCodeBox;
        private System.Windows.Forms.Button calcButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.Label zoneCostLabel;
        private System.Windows.Forms.Label weightCostLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label cappedLabel;
    }
}

