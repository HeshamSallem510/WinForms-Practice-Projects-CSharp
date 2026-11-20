namespace Project2StopWatch
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbltime = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Lap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnstart = new System.Windows.Forms.Button();
            this.btnlap = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblbiggestlap = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltime.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.SystemColors.Control;
            this.lbltime.Location = new System.Drawing.Point(257, 46);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(292, 77);
            this.lbltime.TabIndex = 0;
            this.lbltime.Text = "00:00:00";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.listView1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(306, 253);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(393, 185);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InfoText;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Lap,
            this.Time});
            this.listView1.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.IndianRed;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(390, 182);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Lap
            // 
            this.Lap.Text = "Lap";
            this.Lap.Width = 97;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 142;
            // 
            // btnstart
            // 
            this.btnstart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstart.FlatAppearance.BorderSize = 3;
            this.btnstart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstart.Font = new System.Drawing.Font("Sitka Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.ForeColor = System.Drawing.Color.IndianRed;
            this.btnstart.Location = new System.Drawing.Point(89, 145);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(174, 55);
            this.btnstart.TabIndex = 6;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnlap
            // 
            this.btnlap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlap.FlatAppearance.BorderSize = 3;
            this.btnlap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlap.Font = new System.Drawing.Font("Sitka Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlap.ForeColor = System.Drawing.Color.IndianRed;
            this.btnlap.Location = new System.Drawing.Point(89, 256);
            this.btnlap.Name = "btnlap";
            this.btnlap.Size = new System.Drawing.Size(174, 55);
            this.btnlap.TabIndex = 7;
            this.btnlap.Text = "Lap";
            this.btnlap.UseVisualStyleBackColor = true;
            this.btnlap.Click += new System.EventHandler(this.btnlap_Click);
            // 
            // btnstop
            // 
            this.btnstop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstop.FlatAppearance.BorderSize = 3;
            this.btnstop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnstop.Font = new System.Drawing.Font("Sitka Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstop.ForeColor = System.Drawing.Color.IndianRed;
            this.btnstop.Location = new System.Drawing.Point(543, 145);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(174, 55);
            this.btnstop.TabIndex = 8;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btnreset
            // 
            this.btnreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreset.FlatAppearance.BorderSize = 3;
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.Font = new System.Drawing.Font("Sitka Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.IndianRed;
            this.btnreset.Location = new System.Drawing.Point(316, 145);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(174, 55);
            this.btnreset.TabIndex = 9;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(73, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 39);
            this.label2.TabIndex = 11;
            this.label2.Text = "Biggest Lap";
            // 
            // lblbiggestlap
            // 
            this.lblbiggestlap.AutoSize = true;
            this.lblbiggestlap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblbiggestlap.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbiggestlap.ForeColor = System.Drawing.SystemColors.Control;
            this.lblbiggestlap.Location = new System.Drawing.Point(101, 399);
            this.lblbiggestlap.Name = "lblbiggestlap";
            this.lblbiggestlap.Size = new System.Drawing.Size(147, 39);
            this.lblbiggestlap.TabIndex = 12;
            this.lblbiggestlap.Text = "00:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblbiggestlap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnlap);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbltime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Stop Watch";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnlap;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.ColumnHeader Lap;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblbiggestlap;
    }
}

