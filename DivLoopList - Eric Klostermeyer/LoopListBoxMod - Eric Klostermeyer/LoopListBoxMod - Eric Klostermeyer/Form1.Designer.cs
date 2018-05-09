namespace LoopListBoxMod___Eric_Klostermeyer
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
            this.startYearLabel = new System.Windows.Forms.Label();
            this.endYearLabel = new System.Windows.Forms.Label();
            this.startYearBox = new System.Windows.Forms.TextBox();
            this.endYearBox = new System.Windows.Forms.TextBox();
            this.electionCheckBox = new System.Windows.Forms.CheckBox();
            this.censusCheckBox = new System.Windows.Forms.CheckBox();
            this.loopButton = new System.Windows.Forms.Button();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startYearLabel
            // 
            this.startYearLabel.AutoSize = true;
            this.startYearLabel.Location = new System.Drawing.Point(26, 9);
            this.startYearLabel.Name = "startYearLabel";
            this.startYearLabel.Size = new System.Drawing.Size(94, 13);
            this.startYearLabel.TabIndex = 0;
            this.startYearLabel.Text = "Start Year (YYYY):";
            // 
            // endYearLabel
            // 
            this.endYearLabel.AutoSize = true;
            this.endYearLabel.Location = new System.Drawing.Point(165, 9);
            this.endYearLabel.Name = "endYearLabel";
            this.endYearLabel.Size = new System.Drawing.Size(91, 13);
            this.endYearLabel.TabIndex = 1;
            this.endYearLabel.Text = "End Year (YYYY):";
            // 
            // startYearBox
            // 
            this.startYearBox.Location = new System.Drawing.Point(20, 25);
            this.startYearBox.Name = "startYearBox";
            this.startYearBox.Size = new System.Drawing.Size(100, 20);
            this.startYearBox.TabIndex = 2;
            // 
            // endYearBox
            // 
            this.endYearBox.Location = new System.Drawing.Point(156, 25);
            this.endYearBox.Name = "endYearBox";
            this.endYearBox.Size = new System.Drawing.Size(100, 20);
            this.endYearBox.TabIndex = 3;
            // 
            // electionCheckBox
            // 
            this.electionCheckBox.AutoSize = true;
            this.electionCheckBox.Location = new System.Drawing.Point(44, 63);
            this.electionCheckBox.Name = "electionCheckBox";
            this.electionCheckBox.Size = new System.Drawing.Size(192, 17);
            this.electionCheckBox.TabIndex = 4;
            this.electionCheckBox.Text = "Indicate Presidential Election Years";
            this.electionCheckBox.UseVisualStyleBackColor = true;
            // 
            // censusCheckBox
            // 
            this.censusCheckBox.AutoSize = true;
            this.censusCheckBox.Location = new System.Drawing.Point(44, 86);
            this.censusCheckBox.Name = "censusCheckBox";
            this.censusCheckBox.Size = new System.Drawing.Size(132, 17);
            this.censusCheckBox.TabIndex = 5;
            this.censusCheckBox.Text = "Indicate Census Years";
            this.censusCheckBox.UseVisualStyleBackColor = true;
            // 
            // loopButton
            // 
            this.loopButton.Location = new System.Drawing.Point(74, 109);
            this.loopButton.Name = "loopButton";
            this.loopButton.Size = new System.Drawing.Size(135, 23);
            this.loopButton.TabIndex = 6;
            this.loopButton.Text = "Loop Thru The Years";
            this.loopButton.UseVisualStyleBackColor = true;
            this.loopButton.Click += new System.EventHandler(this.loopButton_Click);
            // 
            // resultListBox
            // 
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.Location = new System.Drawing.Point(12, 185);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(260, 264);
            this.resultListBox.TabIndex = 7;
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(104, 138);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(75, 23);
            this.clearAllButton.TabIndex = 8;
            this.clearAllButton.Text = "Clear All";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.resultListBox);
            this.Controls.Add(this.loopButton);
            this.Controls.Add(this.censusCheckBox);
            this.Controls.Add(this.electionCheckBox);
            this.Controls.Add(this.endYearBox);
            this.Controls.Add(this.startYearBox);
            this.Controls.Add(this.endYearLabel);
            this.Controls.Add(this.startYearLabel);
            this.Name = "Form1";
            this.Text = "List Box Loop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startYearLabel;
        private System.Windows.Forms.Label endYearLabel;
        private System.Windows.Forms.TextBox startYearBox;
        private System.Windows.Forms.TextBox endYearBox;
        private System.Windows.Forms.CheckBox electionCheckBox;
        private System.Windows.Forms.CheckBox censusCheckBox;
        private System.Windows.Forms.Button loopButton;
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.Button clearAllButton;
    }
}

