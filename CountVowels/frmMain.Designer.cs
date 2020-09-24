namespace CountVowels
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEntry = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.txtVowels = new System.Windows.Forms.TextBox();
            this.lblVowels = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter text for program to count the number of vowels.\r\nBoth upper and lowercase v" +
    "owels are counted.\r\nY is not considered a vowel.";
            // 
            // txtEntry
            // 
            this.txtEntry.Location = new System.Drawing.Point(12, 69);
            this.txtEntry.Multiline = true;
            this.txtEntry.Name = "txtEntry";
            this.txtEntry.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEntry.Size = new System.Drawing.Size(257, 104);
            this.txtEntry.TabIndex = 1;
            this.txtEntry.TextChanged += new System.EventHandler(this.txtEntry_TextChanged);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(12, 179);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // txtVowels
            // 
            this.txtVowels.Location = new System.Drawing.Point(93, 179);
            this.txtVowels.Name = "txtVowels";
            this.txtVowels.ReadOnly = true;
            this.txtVowels.Size = new System.Drawing.Size(100, 20);
            this.txtVowels.TabIndex = 3;
            this.txtVowels.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblVowels
            // 
            this.lblVowels.AutoSize = true;
            this.lblVowels.Location = new System.Drawing.Point(202, 184);
            this.lblVowels.Name = "lblVowels";
            this.lblVowels.Size = new System.Drawing.Size(41, 13);
            this.lblVowels.TabIndex = 4;
            this.lblVowels.Text = "Vowels";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 216);
            this.Controls.Add(this.lblVowels);
            this.Controls.Add(this.txtVowels);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.txtEntry);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Vowel Count";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEntry;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.TextBox txtVowels;
        private System.Windows.Forms.Label lblVowels;
    }
}

