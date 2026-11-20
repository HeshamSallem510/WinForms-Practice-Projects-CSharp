namespace Project3QuizzApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnplay = new System.Windows.Forms.Button();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.lbldifficulty = new System.Windows.Forms.Label();
            this.rbBeginner = new System.Windows.Forms.RadioButton();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.rbHard = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnplay
            // 
            this.btnplay.Enabled = false;
            this.btnplay.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnplay.Location = new System.Drawing.Point(280, 241);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(216, 70);
            this.btnplay.TabIndex = 0;
            this.btnplay.Text = "Play";
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.Location = new System.Drawing.Point(263, 31);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(283, 85);
            this.lblwelcome.TabIndex = 1;
            this.lblwelcome.Text = "Welcome! ";
            // 
            // lbldifficulty
            // 
            this.lbldifficulty.AutoSize = true;
            this.lbldifficulty.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldifficulty.Location = new System.Drawing.Point(192, 116);
            this.lbldifficulty.Name = "lbldifficulty";
            this.lbldifficulty.Size = new System.Drawing.Size(407, 51);
            this.lbldifficulty.TabIndex = 2;
            this.lbldifficulty.Text = "Please select the difficulty.";
            // 
            // rbBeginner
            // 
            this.rbBeginner.AutoSize = true;
            this.rbBeginner.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBeginner.Location = new System.Drawing.Point(130, 195);
            this.rbBeginner.Name = "rbBeginner";
            this.rbBeginner.Size = new System.Drawing.Size(76, 23);
            this.rbBeginner.TabIndex = 3;
            this.rbBeginner.Tag = "";
            this.rbBeginner.Text = "Beginner";
            this.rbBeginner.UseVisualStyleBackColor = true;
            this.rbBeginner.Click += new System.EventHandler(this.Button_Click);
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEasy.Location = new System.Drawing.Point(280, 195);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(52, 23);
            this.rbEasy.TabIndex = 4;
            this.rbEasy.Text = "Easy";
            this.rbEasy.UseVisualStyleBackColor = true;
            this.rbEasy.Click += new System.EventHandler(this.Button_Click);
            // 
            // rbHard
            // 
            this.rbHard.AutoSize = true;
            this.rbHard.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHard.Location = new System.Drawing.Point(591, 195);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(55, 23);
            this.rbHard.TabIndex = 5;
            this.rbHard.Text = "Hard";
            this.rbHard.UseVisualStyleBackColor = true;
            this.rbHard.Click += new System.EventHandler(this.Button_Click);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedium.Location = new System.Drawing.Point(425, 195);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(71, 23);
            this.rbMedium.TabIndex = 6;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.Click += new System.EventHandler(this.Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbMedium);
            this.Controls.Add(this.rbHard);
            this.Controls.Add(this.rbEasy);
            this.Controls.Add(this.rbBeginner);
            this.Controls.Add(this.lbldifficulty);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.btnplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "QuickFootballQuizz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Label lbldifficulty;
        private System.Windows.Forms.RadioButton rbBeginner;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.RadioButton rbHard;
        private System.Windows.Forms.RadioButton rbMedium;
    }
}

