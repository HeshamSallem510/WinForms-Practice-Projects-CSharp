namespace Project3QuizzApp
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblQuestion = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.rbAnswer2 = new System.Windows.Forms.RadioButton();
            this.rbAnswer4 = new System.Windows.Forms.RadioButton();
            this.rbAnswer3 = new System.Windows.Forms.RadioButton();
            this.rbAnswer1 = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblminutesleft = new System.Windows.Forms.Label();
            this.lbltimeleft = new System.Windows.Forms.Label();
            this.lblprogressbar = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(157, 275);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(476, 58);
            this.lblQuestion.TabIndex = 8;
            this.lblQuestion.Text = "Question";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPlayAgain.Enabled = false;
            this.btnPlayAgain.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayAgain.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlayAgain.Location = new System.Drawing.Point(532, 365);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(139, 46);
            this.btnPlayAgain.TabIndex = 13;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnsubmit.Enabled = false;
            this.btnsubmit.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubmit.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsubmit.Location = new System.Drawing.Point(134, 365);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(139, 46);
            this.btnsubmit.TabIndex = 14;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // rbAnswer2
            // 
            this.rbAnswer2.AutoSize = true;
            this.rbAnswer2.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnswer2.Location = new System.Drawing.Point(206, 8);
            this.rbAnswer2.Name = "rbAnswer2";
            this.rbAnswer2.Size = new System.Drawing.Size(78, 23);
            this.rbAnswer2.TabIndex = 18;
            this.rbAnswer2.Text = "Answer2";
            this.rbAnswer2.UseVisualStyleBackColor = true;
            this.rbAnswer2.CheckedChanged += new System.EventHandler(this.rbAnswerChosen);
            // 
            // rbAnswer4
            // 
            this.rbAnswer4.AutoSize = true;
            this.rbAnswer4.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnswer4.Location = new System.Drawing.Point(522, 8);
            this.rbAnswer4.Name = "rbAnswer4";
            this.rbAnswer4.Size = new System.Drawing.Size(78, 23);
            this.rbAnswer4.TabIndex = 17;
            this.rbAnswer4.Text = "Answer4";
            this.rbAnswer4.UseVisualStyleBackColor = true;
            this.rbAnswer4.CheckedChanged += new System.EventHandler(this.rbAnswerChosen);
            // 
            // rbAnswer3
            // 
            this.rbAnswer3.AutoSize = true;
            this.rbAnswer3.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnswer3.Location = new System.Drawing.Point(364, 8);
            this.rbAnswer3.Name = "rbAnswer3";
            this.rbAnswer3.Size = new System.Drawing.Size(78, 23);
            this.rbAnswer3.TabIndex = 16;
            this.rbAnswer3.Text = "Answer3";
            this.rbAnswer3.UseVisualStyleBackColor = true;
            this.rbAnswer3.CheckedChanged += new System.EventHandler(this.rbAnswerChosen);
            // 
            // rbAnswer1
            // 
            this.rbAnswer1.AutoSize = true;
            this.rbAnswer1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnswer1.Location = new System.Drawing.Point(48, 8);
            this.rbAnswer1.Name = "rbAnswer1";
            this.rbAnswer1.Size = new System.Drawing.Size(78, 23);
            this.rbAnswer1.TabIndex = 15;
            this.rbAnswer1.Text = "Answer1";
            this.rbAnswer1.UseVisualStyleBackColor = true;
            this.rbAnswer1.CheckedChanged += new System.EventHandler(this.rbAnswerChosen);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.jpg");
            this.imageList1.Images.SetKeyName(1, "3.jpg");
            this.imageList1.Images.SetKeyName(2, "4.jpg");
            this.imageList1.Images.SetKeyName(3, "5.jpg");
            this.imageList1.Images.SetKeyName(4, "6.jpg");
            this.imageList1.Images.SetKeyName(5, "7.jpg");
            this.imageList1.Images.SetKeyName(6, "8.jpg");
            this.imageList1.Images.SetKeyName(7, "59.jpg");
            this.imageList1.Images.SetKeyName(8, "LOST.jpg");
            this.imageList1.Images.SetKeyName(9, "WIN.jpg");
            // 
            // lblminutesleft
            // 
            this.lblminutesleft.AutoSize = true;
            this.lblminutesleft.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblminutesleft.Location = new System.Drawing.Point(94, 83);
            this.lblminutesleft.Name = "lblminutesleft";
            this.lblminutesleft.Size = new System.Drawing.Size(65, 28);
            this.lblminutesleft.TabIndex = 21;
            this.lblminutesleft.Text = "00:00";
            // 
            // lbltimeleft
            // 
            this.lbltimeleft.AutoSize = true;
            this.lbltimeleft.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimeleft.Location = new System.Drawing.Point(48, 36);
            this.lbltimeleft.Name = "lbltimeleft";
            this.lbltimeleft.Size = new System.Drawing.Size(152, 47);
            this.lbltimeleft.TabIndex = 22;
            this.lbltimeleft.Text = "Time Left";
            // 
            // lblprogressbar
            // 
            this.lblprogressbar.AutoSize = true;
            this.lblprogressbar.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprogressbar.Location = new System.Drawing.Point(534, 36);
            this.lblprogressbar.Name = "lblprogressbar";
            this.lblprogressbar.Size = new System.Drawing.Size(190, 43);
            this.lblprogressbar.TabIndex = 23;
            this.lblprogressbar.Text = "Questions Left";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(570, 92);
            this.progressBar1.Maximum = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(207, 19);
            this.progressBar1.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Location = new System.Drawing.Point(264, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbAnswer2);
            this.panel1.Controls.Add(this.rbAnswer4);
            this.panel1.Controls.Add(this.rbAnswer3);
            this.panel1.Controls.Add(this.rbAnswer1);
            this.panel1.Location = new System.Drawing.Point(86, 328);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 37);
            this.panel1.TabIndex = 25;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblprogressbar);
            this.Controls.Add(this.lbltimeleft);
            this.Controls.Add(this.lblminutesleft);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblQuestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "QuickFootballQuizz";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.RadioButton rbAnswer2;
        private System.Windows.Forms.RadioButton rbAnswer4;
        private System.Windows.Forms.RadioButton rbAnswer3;
        private System.Windows.Forms.RadioButton rbAnswer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblminutesleft;
        private System.Windows.Forms.Label lbltimeleft;
        private System.Windows.Forms.Label lblprogressbar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
    }
}