namespace Kurambler
{
    partial class UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.btnImportFile = new System.Windows.Forms.Button();
            this.txtWordCount = new System.Windows.Forms.Label();
            this.lstWords = new System.Windows.Forms.ListBox();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtboxScrambled = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUnscramble = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImportFile
            // 
            this.btnImportFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnImportFile.Location = new System.Drawing.Point(6, 26);
            this.btnImportFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImportFile.Name = "btnImportFile";
            this.btnImportFile.Size = new System.Drawing.Size(139, 31);
            this.btnImportFile.TabIndex = 0;
            this.btnImportFile.Text = "Import File";
            this.btnImportFile.UseVisualStyleBackColor = true;
            this.btnImportFile.Click += new System.EventHandler(this.BtnImportFile_Click);
            // 
            // txtWordCount
            // 
            this.txtWordCount.AutoSize = true;
            this.txtWordCount.Location = new System.Drawing.Point(6, 61);
            this.txtWordCount.Name = "txtWordCount";
            this.txtWordCount.Size = new System.Drawing.Size(59, 19);
            this.txtWordCount.TabIndex = 1;
            this.txtWordCount.Text = "Words: 0";
            // 
            // lstWords
            // 
            this.lstWords.FormattingEnabled = true;
            this.lstWords.ItemHeight = 19;
            this.lstWords.Location = new System.Drawing.Point(6, 26);
            this.lstWords.Name = "lstWords";
            this.lstWords.Size = new System.Drawing.Size(236, 327);
            this.lstWords.TabIndex = 2;
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 19;
            this.lstResults.Location = new System.Drawing.Point(187, 14);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(236, 118);
            this.lstResults.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstWords);
            this.groupBox1.Location = new System.Drawing.Point(447, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 369);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Complete Word List";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnImportFile);
            this.groupBox2.Controls.Add(this.txtWordCount);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 86);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setup";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUnscramble);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtboxScrambled);
            this.groupBox3.Controls.Add(this.lstResults);
            this.groupBox3.Location = new System.Drawing.Point(12, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(429, 138);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Unscrambler";
            // 
            // txtboxScrambled
            // 
            this.txtboxScrambled.Location = new System.Drawing.Point(10, 61);
            this.txtboxScrambled.Name = "txtboxScrambled";
            this.txtboxScrambled.Size = new System.Drawing.Size(171, 27);
            this.txtboxScrambled.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Scrambled text below!";
            // 
            // btnUnscramble
            // 
            this.btnUnscramble.Location = new System.Drawing.Point(57, 94);
            this.btnUnscramble.Name = "btnUnscramble";
            this.btnUnscramble.Size = new System.Drawing.Size(75, 23);
            this.btnUnscramble.TabIndex = 6;
            this.btnUnscramble.Text = "Go!";
            this.btnUnscramble.UseVisualStyleBackColor = true;
            this.btnUnscramble.Click += new System.EventHandler(this.BtnUnscramble_Click);
            // 
            // UI
            // 
            this.AcceptButton = this.btnUnscramble;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::Kurambler.Properties.Resources.pinkGradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(708, 387);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UI";
            this.Text = "Kurambler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImportFile;
        private System.Windows.Forms.Label txtWordCount;
        private System.Windows.Forms.ListBox lstWords;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUnscramble;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxScrambled;
    }
}

