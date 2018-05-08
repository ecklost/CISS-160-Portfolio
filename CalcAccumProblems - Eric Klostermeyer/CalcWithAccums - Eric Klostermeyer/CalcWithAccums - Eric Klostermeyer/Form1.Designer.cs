namespace CalcWithAccums___Eric_Klostermeyer
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
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.cubicYardToCubicFeetLabel = new System.Windows.Forms.Label();
            this.currentPriceLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.currentOrdersGroupBox = new System.Windows.Forms.GroupBox();
            this.currentOrderPriceLabel = new System.Windows.Forms.Label();
            this.cubicYardsOutputLabel = new System.Windows.Forms.Label();
            this.cubicFeetOutputLabel = new System.Windows.Forms.Label();
            this.allOrdersGroupBox = new System.Windows.Forms.GroupBox();
            this.totalCubicFeetLabel = new System.Windows.Forms.Label();
            this.totalCubicYardsLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.numberOfOrdersLabel = new System.Windows.Forms.Label();
            this.remainingTruckCapacityGroupBox = new System.Windows.Forms.GroupBox();
            this.emptyTruckCapacityLabel = new System.Windows.Forms.Label();
            this.mulchOrderedLabel = new System.Windows.Forms.Label();
            this.remainingLoadLabel = new System.Windows.Forms.Label();
            this.emptyTruckCapacityTextBox = new System.Windows.Forms.TextBox();
            this.mulchOrderedTextBox = new System.Windows.Forms.TextBox();
            this.remainingLoadTextBox = new System.Windows.Forms.TextBox();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.currentOrdersGroupBox.SuspendLayout();
            this.allOrdersGroupBox.SuspendLayout();
            this.remainingTruckCapacityGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(13, 85);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(59, 13);
            this.heightLabel.TabIndex = 0;
            this.heightLabel.Text = "Height (ft): ";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(13, 50);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(56, 13);
            this.widthLabel.TabIndex = 1;
            this.widthLabel.Text = "Width (ft): ";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(13, 15);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(61, 13);
            this.lengthLabel.TabIndex = 2;
            this.lengthLabel.Text = "Length (ft): ";
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(80, 12);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.lengthTextBox.TabIndex = 3;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(80, 47);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 20);
            this.widthTextBox.TabIndex = 4;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(80, 82);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 5;
            // 
            // cubicYardToCubicFeetLabel
            // 
            this.cubicYardToCubicFeetLabel.AutoSize = true;
            this.cubicYardToCubicFeetLabel.Location = new System.Drawing.Point(13, 120);
            this.cubicYardToCubicFeetLabel.Name = "cubicYardToCubicFeetLabel";
            this.cubicYardToCubicFeetLabel.Size = new System.Drawing.Size(160, 13);
            this.cubicYardToCubicFeetLabel.TabIndex = 6;
            this.cubicYardToCubicFeetLabel.Text = "One Cubic Yard = 27 Cubic Feet";
            // 
            // currentPriceLabel
            // 
            this.currentPriceLabel.AutoSize = true;
            this.currentPriceLabel.Location = new System.Drawing.Point(13, 150);
            this.currentPriceLabel.Name = "currentPriceLabel";
            this.currentPriceLabel.Size = new System.Drawing.Size(203, 13);
            this.currentPriceLabel.TabIndex = 7;
            this.currentPriceLabel.Text = "Current Price of One Cubic Yard = $17.00";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(227, 11);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(227, 46);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(227, 81);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(75, 23);
            this.clearAllButton.TabIndex = 10;
            this.clearAllButton.Text = "Clear All";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(227, 116);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // currentOrdersGroupBox
            // 
            this.currentOrdersGroupBox.Controls.Add(this.currentOrderPriceLabel);
            this.currentOrdersGroupBox.Controls.Add(this.cubicYardsOutputLabel);
            this.currentOrdersGroupBox.Controls.Add(this.cubicFeetOutputLabel);
            this.currentOrdersGroupBox.Location = new System.Drawing.Point(12, 182);
            this.currentOrdersGroupBox.Name = "currentOrdersGroupBox";
            this.currentOrdersGroupBox.Size = new System.Drawing.Size(290, 139);
            this.currentOrdersGroupBox.TabIndex = 12;
            this.currentOrdersGroupBox.TabStop = false;
            this.currentOrdersGroupBox.Text = "Current Order";
            // 
            // currentOrderPriceLabel
            // 
            this.currentOrderPriceLabel.AutoSize = true;
            this.currentOrderPriceLabel.Location = new System.Drawing.Point(10, 75);
            this.currentOrderPriceLabel.Name = "currentOrderPriceLabel";
            this.currentOrderPriceLabel.Size = new System.Drawing.Size(34, 13);
            this.currentOrderPriceLabel.TabIndex = 14;
            this.currentOrderPriceLabel.Text = "Cost: ";
            // 
            // cubicYardsOutputLabel
            // 
            this.cubicYardsOutputLabel.AutoSize = true;
            this.cubicYardsOutputLabel.Location = new System.Drawing.Point(10, 50);
            this.cubicYardsOutputLabel.Name = "cubicYardsOutputLabel";
            this.cubicYardsOutputLabel.Size = new System.Drawing.Size(70, 13);
            this.cubicYardsOutputLabel.TabIndex = 14;
            this.cubicYardsOutputLabel.Text = "Cubic Yards: ";
            // 
            // cubicFeetOutputLabel
            // 
            this.cubicFeetOutputLabel.AutoSize = true;
            this.cubicFeetOutputLabel.Location = new System.Drawing.Point(10, 25);
            this.cubicFeetOutputLabel.Name = "cubicFeetOutputLabel";
            this.cubicFeetOutputLabel.Size = new System.Drawing.Size(64, 13);
            this.cubicFeetOutputLabel.TabIndex = 0;
            this.cubicFeetOutputLabel.Text = "Cubic Feet: ";
            // 
            // allOrdersGroupBox
            // 
            this.allOrdersGroupBox.Controls.Add(this.numberOfOrdersLabel);
            this.allOrdersGroupBox.Controls.Add(this.totalCostLabel);
            this.allOrdersGroupBox.Controls.Add(this.totalCubicYardsLabel);
            this.allOrdersGroupBox.Controls.Add(this.totalCubicFeetLabel);
            this.allOrdersGroupBox.Location = new System.Drawing.Point(318, 182);
            this.allOrdersGroupBox.Name = "allOrdersGroupBox";
            this.allOrdersGroupBox.Size = new System.Drawing.Size(304, 139);
            this.allOrdersGroupBox.TabIndex = 13;
            this.allOrdersGroupBox.TabStop = false;
            this.allOrdersGroupBox.Text = "All Orders";
            // 
            // totalCubicFeetLabel
            // 
            this.totalCubicFeetLabel.AutoSize = true;
            this.totalCubicFeetLabel.Location = new System.Drawing.Point(6, 25);
            this.totalCubicFeetLabel.Name = "totalCubicFeetLabel";
            this.totalCubicFeetLabel.Size = new System.Drawing.Size(91, 13);
            this.totalCubicFeetLabel.TabIndex = 15;
            this.totalCubicFeetLabel.Text = "Total Cubic Feet: ";
            // 
            // totalCubicYardsLabel
            // 
            this.totalCubicYardsLabel.AutoSize = true;
            this.totalCubicYardsLabel.Location = new System.Drawing.Point(6, 50);
            this.totalCubicYardsLabel.Name = "totalCubicYardsLabel";
            this.totalCubicYardsLabel.Size = new System.Drawing.Size(97, 13);
            this.totalCubicYardsLabel.TabIndex = 15;
            this.totalCubicYardsLabel.Text = "Total Cubic Yards: ";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(6, 75);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(61, 13);
            this.totalCostLabel.TabIndex = 15;
            this.totalCostLabel.Text = "Total Cost: ";
            // 
            // numberOfOrdersLabel
            // 
            this.numberOfOrdersLabel.AutoSize = true;
            this.numberOfOrdersLabel.Location = new System.Drawing.Point(6, 100);
            this.numberOfOrdersLabel.Name = "numberOfOrdersLabel";
            this.numberOfOrdersLabel.Size = new System.Drawing.Size(101, 13);
            this.numberOfOrdersLabel.TabIndex = 15;
            this.numberOfOrdersLabel.Text = "Numbers of Orders: ";
            // 
            // remainingTruckCapacityGroupBox
            // 
            this.remainingTruckCapacityGroupBox.Controls.Add(this.remainingLoadTextBox);
            this.remainingTruckCapacityGroupBox.Controls.Add(this.mulchOrderedTextBox);
            this.remainingTruckCapacityGroupBox.Controls.Add(this.emptyTruckCapacityTextBox);
            this.remainingTruckCapacityGroupBox.Controls.Add(this.remainingLoadLabel);
            this.remainingTruckCapacityGroupBox.Controls.Add(this.mulchOrderedLabel);
            this.remainingTruckCapacityGroupBox.Controls.Add(this.emptyTruckCapacityLabel);
            this.remainingTruckCapacityGroupBox.Location = new System.Drawing.Point(12, 330);
            this.remainingTruckCapacityGroupBox.Name = "remainingTruckCapacityGroupBox";
            this.remainingTruckCapacityGroupBox.Size = new System.Drawing.Size(610, 100);
            this.remainingTruckCapacityGroupBox.TabIndex = 15;
            this.remainingTruckCapacityGroupBox.TabStop = false;
            this.remainingTruckCapacityGroupBox.Text = "Remaining Truck Capacity";
            // 
            // emptyTruckCapacityLabel
            // 
            this.emptyTruckCapacityLabel.AutoSize = true;
            this.emptyTruckCapacityLabel.Location = new System.Drawing.Point(9, 20);
            this.emptyTruckCapacityLabel.Name = "emptyTruckCapacityLabel";
            this.emptyTruckCapacityLabel.Size = new System.Drawing.Size(111, 26);
            this.emptyTruckCapacityLabel.TabIndex = 0;
            this.emptyTruckCapacityLabel.Text = "Empty Truck Capacity\r\n(Cubic Yards):";
            this.emptyTruckCapacityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mulchOrderedLabel
            // 
            this.mulchOrderedLabel.AutoSize = true;
            this.mulchOrderedLabel.Location = new System.Drawing.Point(270, 20);
            this.mulchOrderedLabel.Name = "mulchOrderedLabel";
            this.mulchOrderedLabel.Size = new System.Drawing.Size(77, 26);
            this.mulchOrderedLabel.TabIndex = 1;
            this.mulchOrderedLabel.Text = "Mulch Ordered\r\n(Cubic Yards):";
            this.mulchOrderedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // remainingLoadLabel
            // 
            this.remainingLoadLabel.AutoSize = true;
            this.remainingLoadLabel.Location = new System.Drawing.Point(507, 20);
            this.remainingLoadLabel.Name = "remainingLoadLabel";
            this.remainingLoadLabel.Size = new System.Drawing.Size(84, 26);
            this.remainingLoadLabel.TabIndex = 16;
            this.remainingLoadLabel.Text = "Remaining Load\r\n(Cubic Yards):";
            this.remainingLoadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emptyTruckCapacityTextBox
            // 
            this.emptyTruckCapacityTextBox.Enabled = false;
            this.emptyTruckCapacityTextBox.Location = new System.Drawing.Point(10, 60);
            this.emptyTruckCapacityTextBox.Name = "emptyTruckCapacityTextBox";
            this.emptyTruckCapacityTextBox.Size = new System.Drawing.Size(108, 20);
            this.emptyTruckCapacityTextBox.TabIndex = 17;
            this.emptyTruckCapacityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mulchOrderedTextBox
            // 
            this.mulchOrderedTextBox.Enabled = false;
            this.mulchOrderedTextBox.Location = new System.Drawing.Point(252, 60);
            this.mulchOrderedTextBox.Name = "mulchOrderedTextBox";
            this.mulchOrderedTextBox.Size = new System.Drawing.Size(108, 20);
            this.mulchOrderedTextBox.TabIndex = 18;
            this.mulchOrderedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // remainingLoadTextBox
            // 
            this.remainingLoadTextBox.BackColor = System.Drawing.Color.Lime;
            this.remainingLoadTextBox.Enabled = false;
            this.remainingLoadTextBox.Location = new System.Drawing.Point(495, 60);
            this.remainingLoadTextBox.Name = "remainingLoadTextBox";
            this.remainingLoadTextBox.Size = new System.Drawing.Size(108, 20);
            this.remainingLoadTextBox.TabIndex = 19;
            this.remainingLoadTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // logoBox
            // 
            this.logoBox.Image = global::CalcWithAccums___Eric_Klostermeyer.Properties.Resources.shovel_5;
            this.logoBox.InitialImage = global::CalcWithAccums___Eric_Klostermeyer.Properties.Resources.shovel_5;
            this.logoBox.Location = new System.Drawing.Point(318, 12);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(304, 151);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoBox.TabIndex = 14;
            this.logoBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 442);
            this.Controls.Add(this.remainingTruckCapacityGroupBox);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.allOrdersGroupBox);
            this.Controls.Add(this.currentOrdersGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.currentPriceLabel);
            this.Controls.Add(this.cubicYardToCubicFeetLabel);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.heightLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.currentOrdersGroupBox.ResumeLayout(false);
            this.currentOrdersGroupBox.PerformLayout();
            this.allOrdersGroupBox.ResumeLayout(false);
            this.allOrdersGroupBox.PerformLayout();
            this.remainingTruckCapacityGroupBox.ResumeLayout(false);
            this.remainingTruckCapacityGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label cubicYardToCubicFeetLabel;
        private System.Windows.Forms.Label currentPriceLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox currentOrdersGroupBox;
        private System.Windows.Forms.GroupBox allOrdersGroupBox;
        private System.Windows.Forms.Label currentOrderPriceLabel;
        private System.Windows.Forms.Label cubicYardsOutputLabel;
        private System.Windows.Forms.Label cubicFeetOutputLabel;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label numberOfOrdersLabel;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label totalCubicYardsLabel;
        private System.Windows.Forms.Label totalCubicFeetLabel;
        private System.Windows.Forms.GroupBox remainingTruckCapacityGroupBox;
        private System.Windows.Forms.Label emptyTruckCapacityLabel;
        private System.Windows.Forms.Label remainingLoadLabel;
        private System.Windows.Forms.Label mulchOrderedLabel;
        private System.Windows.Forms.TextBox remainingLoadTextBox;
        private System.Windows.Forms.TextBox mulchOrderedTextBox;
        private System.Windows.Forms.TextBox emptyTruckCapacityTextBox;
    }
}

