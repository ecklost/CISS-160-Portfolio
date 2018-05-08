namespace SalesTaxCalculator___Eric_Klostermeyer
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
            this.salesLabel = new System.Windows.Forms.Label();
            this.lorainSalesTaxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.salesTextBox = new System.Windows.Forms.TextBox();
            this.lorainSalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.addedTaxTextBox = new System.Windows.Forms.TextBox();
            this.addedTaxLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // salesLabel
            // 
            this.salesLabel.AutoSize = true;
            this.salesLabel.Location = new System.Drawing.Point(60, 40);
            this.salesLabel.Name = "salesLabel";
            this.salesLabel.Size = new System.Drawing.Size(103, 13);
            this.salesLabel.TabIndex = 0;
            this.salesLabel.Text = "Enter Sales Amount:";
            // 
            // lorainSalesTaxLabel
            // 
            this.lorainSalesTaxLabel.AutoSize = true;
            this.lorainSalesTaxLabel.Location = new System.Drawing.Point(52, 133);
            this.lorainSalesTaxLabel.Name = "lorainSalesTaxLabel";
            this.lorainSalesTaxLabel.Size = new System.Drawing.Size(125, 13);
            this.lorainSalesTaxLabel.TabIndex = 1;
            this.lorainSalesTaxLabel.Text = "Lorain County Sales Tax:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(76, 234);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(73, 13);
            this.totalLabel.TabIndex = 2;
            this.totalLabel.Text = "Total Amount:";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(41, 94);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 3;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(122, 94);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // salesTextBox
            // 
            this.salesTextBox.Location = new System.Drawing.Point(63, 56);
            this.salesTextBox.Name = "salesTextBox";
            this.salesTextBox.Size = new System.Drawing.Size(100, 20);
            this.salesTextBox.TabIndex = 5;
            // 
            // lorainSalesTaxTextBox
            // 
            this.lorainSalesTaxTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(127)))));
            this.lorainSalesTaxTextBox.Enabled = false;
            this.lorainSalesTaxTextBox.Location = new System.Drawing.Point(63, 149);
            this.lorainSalesTaxTextBox.Name = "lorainSalesTaxTextBox";
            this.lorainSalesTaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.lorainSalesTaxTextBox.TabIndex = 6;
            this.lorainSalesTaxTextBox.Text = "6.75%";
            // 
            // totalTextBox
            // 
            this.totalTextBox.BackColor = System.Drawing.Color.Aquamarine;
            this.totalTextBox.Enabled = false;
            this.totalTextBox.Location = new System.Drawing.Point(63, 250);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 7;
            // 
            // addedTaxTextBox
            // 
            this.addedTaxTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(116)))), ((int)(((byte)(255)))));
            this.addedTaxTextBox.Location = new System.Drawing.Point(63, 200);
            this.addedTaxTextBox.Name = "addedTaxTextBox";
            this.addedTaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.addedTaxTextBox.TabIndex = 8;
            // 
            // addedTaxLabel
            // 
            this.addedTaxLabel.AutoSize = true;
            this.addedTaxLabel.Enabled = false;
            this.addedTaxLabel.Location = new System.Drawing.Point(81, 184);
            this.addedTaxLabel.Name = "addedTaxLabel";
            this.addedTaxLabel.Size = new System.Drawing.Size(62, 13);
            this.addedTaxLabel.TabIndex = 9;
            this.addedTaxLabel.Text = "Added Tax:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 291);
            this.Controls.Add(this.addedTaxLabel);
            this.Controls.Add(this.addedTaxTextBox);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.lorainSalesTaxTextBox);
            this.Controls.Add(this.salesTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.lorainSalesTaxLabel);
            this.Controls.Add(this.salesLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label salesLabel;
        private System.Windows.Forms.Label lorainSalesTaxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox salesTextBox;
        private System.Windows.Forms.TextBox lorainSalesTaxTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox addedTaxTextBox;
        private System.Windows.Forms.Label addedTaxLabel;
    }
}

