namespace Project4PasswordGenerator
{
    partial class PasswordGenerator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordGenerator));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCopy = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Checkboxespanel = new System.Windows.Forms.Panel();
            this.chkIncludeNumbers = new System.Windows.Forms.CheckBox();
            this.chkIncludeSymbols = new System.Windows.Forms.CheckBox();
            this.chkIncludeLowercaseLetters = new System.Windows.Forms.CheckBox();
            this.chkUppercaseLetters = new System.Windows.Forms.CheckBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblStrength = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShowTicks = new System.Windows.Forms.ToolStripMenuItem();
            this.lblcharacters = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Checkboxespanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(88, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password Generator";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnCopy);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Location = new System.Drawing.Point(19, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 45);
            this.panel1.TabIndex = 0;
            // 
            // btnCopy
            // 
            this.btnCopy.BackgroundImage = global::Project4PasswordGenerator.Properties.Resources.copy_two_paper_sheets_stroke_symbol_of_interface_icon_icons_com_57868;
            this.btnCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Location = new System.Drawing.Point(227, 7);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(29, 29);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPassword.Location = new System.Drawing.Point(10, 13);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(68, 16);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.Checkboxespanel);
            this.panel2.Controls.Add(this.btnGenerate);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Controls.Add(this.lblcharacters);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(19, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 333);
            this.panel2.TabIndex = 2;
            // 
            // Checkboxespanel
            // 
            this.Checkboxespanel.BackColor = System.Drawing.Color.Transparent;
            this.Checkboxespanel.Controls.Add(this.chkIncludeNumbers);
            this.Checkboxespanel.Controls.Add(this.chkIncludeSymbols);
            this.Checkboxespanel.Controls.Add(this.chkIncludeLowercaseLetters);
            this.Checkboxespanel.Controls.Add(this.chkUppercaseLetters);
            this.Checkboxespanel.Location = new System.Drawing.Point(6, 84);
            this.Checkboxespanel.Name = "Checkboxespanel";
            this.Checkboxespanel.Size = new System.Drawing.Size(238, 132);
            this.Checkboxespanel.TabIndex = 2;
            // 
            // chkIncludeNumbers
            // 
            this.chkIncludeNumbers.AutoSize = true;
            this.chkIncludeNumbers.Checked = true;
            this.chkIncludeNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeNumbers.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncludeNumbers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkIncludeNumbers.Location = new System.Drawing.Point(8, 69);
            this.chkIncludeNumbers.Name = "chkIncludeNumbers";
            this.chkIncludeNumbers.Size = new System.Drawing.Size(133, 20);
            this.chkIncludeNumbers.TabIndex = 5;
            this.chkIncludeNumbers.Tag = "2";
            this.chkIncludeNumbers.Text = "Include Numbers";
            this.chkIncludeNumbers.UseVisualStyleBackColor = true;
            this.chkIncludeNumbers.CheckedChanged += new System.EventHandler(this.ChangesToCheckBoxes);
            // 
            // chkIncludeSymbols
            // 
            this.chkIncludeSymbols.AutoSize = true;
            this.chkIncludeSymbols.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncludeSymbols.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkIncludeSymbols.Location = new System.Drawing.Point(8, 95);
            this.chkIncludeSymbols.Name = "chkIncludeSymbols";
            this.chkIncludeSymbols.Size = new System.Drawing.Size(131, 20);
            this.chkIncludeSymbols.TabIndex = 6;
            this.chkIncludeSymbols.Tag = "3";
            this.chkIncludeSymbols.Text = "Include Symbols";
            this.chkIncludeSymbols.UseVisualStyleBackColor = true;
            this.chkIncludeSymbols.CheckedChanged += new System.EventHandler(this.ChangesToCheckBoxes);
            // 
            // chkIncludeLowercaseLetters
            // 
            this.chkIncludeLowercaseLetters.AutoSize = true;
            this.chkIncludeLowercaseLetters.Checked = true;
            this.chkIncludeLowercaseLetters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeLowercaseLetters.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncludeLowercaseLetters.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkIncludeLowercaseLetters.Location = new System.Drawing.Point(8, 43);
            this.chkIncludeLowercaseLetters.Name = "chkIncludeLowercaseLetters";
            this.chkIncludeLowercaseLetters.Size = new System.Drawing.Size(193, 20);
            this.chkIncludeLowercaseLetters.TabIndex = 4;
            this.chkIncludeLowercaseLetters.Tag = "1";
            this.chkIncludeLowercaseLetters.Text = "Include Lowercase Letters";
            this.chkIncludeLowercaseLetters.UseVisualStyleBackColor = true;
            this.chkIncludeLowercaseLetters.CheckedChanged += new System.EventHandler(this.ChangesToCheckBoxes);
            // 
            // chkUppercaseLetters
            // 
            this.chkUppercaseLetters.AutoSize = true;
            this.chkUppercaseLetters.Checked = true;
            this.chkUppercaseLetters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUppercaseLetters.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUppercaseLetters.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkUppercaseLetters.Location = new System.Drawing.Point(8, 17);
            this.chkUppercaseLetters.Name = "chkUppercaseLetters";
            this.chkUppercaseLetters.Size = new System.Drawing.Size(191, 20);
            this.chkUppercaseLetters.TabIndex = 3;
            this.chkUppercaseLetters.Tag = "0";
            this.chkUppercaseLetters.Text = "Include Uppercase Letters";
            this.chkUppercaseLetters.UseVisualStyleBackColor = true;
            this.chkUppercaseLetters.CheckedChanged += new System.EventHandler(this.ChangesToCheckBoxes);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.PaleGreen;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(14, 276);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(235, 42);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "GENERATE →";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.progressBar2);
            this.panel3.Controls.Add(this.progressBar3);
            this.panel3.Controls.Add(this.progressBar4);
            this.panel3.Controls.Add(this.progressBar1);
            this.panel3.Controls.Add(this.lblStrength);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(14, 216);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 44);
            this.panel3.TabIndex = 9;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(183, 6);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(10, 32);
            this.progressBar2.TabIndex = 7;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(199, 6);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(10, 32);
            this.progressBar3.TabIndex = 6;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(215, 6);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(10, 32);
            this.progressBar4.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(166, 6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(10, 32);
            this.progressBar1.TabIndex = 4;
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrength.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStrength.Location = new System.Drawing.Point(93, 14);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(68, 15);
            this.lblStrength.TabIndex = 3;
            this.lblStrength.Text = "STRENGTH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(10, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "STRENGTH";
            // 
            // trackBar1
            // 
            this.trackBar1.ContextMenuStrip = this.contextMenuStrip1;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(6, 50);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(250, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowTicks});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 26);
            // 
            // tsmShowTicks
            // 
            this.tsmShowTicks.Name = "tsmShowTicks";
            this.tsmShowTicks.Size = new System.Drawing.Size(108, 22);
            this.tsmShowTicks.Text = "Show Ticks";
            this.tsmShowTicks.Click += new System.EventHandler(this.tsmShowTicks_Click);
            // 
            // lblcharacters
            // 
            this.lblcharacters.AutoSize = true;
            this.lblcharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcharacters.ForeColor = System.Drawing.Color.PaleGreen;
            this.lblcharacters.Location = new System.Drawing.Point(229, 18);
            this.lblcharacters.Name = "lblcharacters";
            this.lblcharacters.Size = new System.Drawing.Size(16, 18);
            this.lblcharacters.TabIndex = 3;
            this.lblcharacters.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(11, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Character Length";
            // 
            // PasswordGenerator
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(297, 443);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordGenerator";
            this.Text = "Password Generator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Checkboxespanel.ResumeLayout(false);
            this.Checkboxespanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkUppercaseLetters;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblcharacters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox chkIncludeNumbers;
        private System.Windows.Forms.CheckBox chkIncludeSymbols;
        private System.Windows.Forms.CheckBox chkIncludeLowercaseLetters;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Panel Checkboxespanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmShowTicks;
    }
}

