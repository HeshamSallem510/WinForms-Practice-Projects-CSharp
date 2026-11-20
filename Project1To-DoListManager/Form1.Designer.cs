namespace Project1To_DoListManager
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Login");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Clock On");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblquote = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUncheckAllTasks = new System.Windows.Forms.Button();
            this.btnCheckAllTasks = new System.Windows.Forms.Button();
            this.btnRemoveAllTasks = new System.Windows.Forms.Button();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.btnAddSubTask = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.pbOverAllCompletion = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.pbTaskProgress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnIncreaseProgress = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblquote);
            this.groupBox1.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Today\'s Message";
            // 
            // lblquote
            // 
            this.lblquote.Location = new System.Drawing.Point(6, 20);
            this.lblquote.Name = "lblquote";
            this.lblquote.Size = new System.Drawing.Size(238, 77);
            this.lblquote.TabIndex = 0;
            this.lblquote.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Task";
            // 
            // txtTask
            // 
            this.txtTask.BackColor = System.Drawing.Color.Beige;
            this.txtTask.Location = new System.Drawing.Point(28, 204);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(250, 20);
            this.txtTask.TabIndex = 0;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTask.FlatAppearance.BorderColor = System.Drawing.Color.Beige;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.Location = new System.Drawing.Point(1, 1);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(106, 46);
            this.btnAddTask.TabIndex = 3;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnUncheckAllTasks);
            this.panel1.Controls.Add(this.btnCheckAllTasks);
            this.panel1.Controls.Add(this.btnRemoveAllTasks);
            this.panel1.Controls.Add(this.btnRemoveTask);
            this.panel1.Controls.Add(this.btnAddSubTask);
            this.panel1.Controls.Add(this.btnAddTask);
            this.panel1.Location = new System.Drawing.Point(3, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 150);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project1To_DoListManager.Properties.Resources.heart_list_task_to_do_icon_146658;
            this.pictureBox1.Location = new System.Drawing.Point(216, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnUncheckAllTasks
            // 
            this.btnUncheckAllTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUncheckAllTasks.FlatAppearance.BorderColor = System.Drawing.Color.Beige;
            this.btnUncheckAllTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUncheckAllTasks.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUncheckAllTasks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUncheckAllTasks.Location = new System.Drawing.Point(112, 103);
            this.btnUncheckAllTasks.Name = "btnUncheckAllTasks";
            this.btnUncheckAllTasks.Size = new System.Drawing.Size(106, 46);
            this.btnUncheckAllTasks.TabIndex = 8;
            this.btnUncheckAllTasks.Text = "Uncheck All Tasks";
            this.btnUncheckAllTasks.UseVisualStyleBackColor = true;
            this.btnUncheckAllTasks.Click += new System.EventHandler(this.btnUncheckAllTasks_Click);
            // 
            // btnCheckAllTasks
            // 
            this.btnCheckAllTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckAllTasks.FlatAppearance.BorderColor = System.Drawing.Color.Beige;
            this.btnCheckAllTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckAllTasks.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckAllTasks.Location = new System.Drawing.Point(2, 103);
            this.btnCheckAllTasks.Name = "btnCheckAllTasks";
            this.btnCheckAllTasks.Size = new System.Drawing.Size(106, 46);
            this.btnCheckAllTasks.TabIndex = 7;
            this.btnCheckAllTasks.Text = "Check All Tasks";
            this.btnCheckAllTasks.UseVisualStyleBackColor = true;
            this.btnCheckAllTasks.Click += new System.EventHandler(this.btnCheckAllTasks_Click);
            // 
            // btnRemoveAllTasks
            // 
            this.btnRemoveAllTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveAllTasks.FlatAppearance.BorderColor = System.Drawing.Color.Beige;
            this.btnRemoveAllTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveAllTasks.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAllTasks.ForeColor = System.Drawing.Color.Red;
            this.btnRemoveAllTasks.Location = new System.Drawing.Point(112, 52);
            this.btnRemoveAllTasks.Name = "btnRemoveAllTasks";
            this.btnRemoveAllTasks.Size = new System.Drawing.Size(106, 46);
            this.btnRemoveAllTasks.TabIndex = 6;
            this.btnRemoveAllTasks.Text = "Remove All Tasks";
            this.btnRemoveAllTasks.UseVisualStyleBackColor = true;
            this.btnRemoveAllTasks.Click += new System.EventHandler(this.btnRemoveAllTasks_Click);
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveTask.FlatAppearance.BorderColor = System.Drawing.Color.Beige;
            this.btnRemoveTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTask.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTask.Location = new System.Drawing.Point(1, 52);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(106, 46);
            this.btnRemoveTask.TabIndex = 5;
            this.btnRemoveTask.Text = "Remove Task";
            this.btnRemoveTask.UseVisualStyleBackColor = true;
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
            // 
            // btnAddSubTask
            // 
            this.btnAddSubTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSubTask.FlatAppearance.BorderColor = System.Drawing.Color.Beige;
            this.btnAddSubTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSubTask.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSubTask.Location = new System.Drawing.Point(112, 1);
            this.btnAddSubTask.Name = "btnAddSubTask";
            this.btnAddSubTask.Size = new System.Drawing.Size(106, 46);
            this.btnAddSubTask.TabIndex = 4;
            this.btnAddSubTask.Text = "Add Sub Task";
            this.btnAddSubTask.UseVisualStyleBackColor = true;
            this.btnAddSubTask.Click += new System.EventHandler(this.btnAddSubTask_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.Beige;
            this.treeView1.CheckBoxes = true;
            this.treeView1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.treeView1.Location = new System.Drawing.Point(316, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Checked = true;
            treeNode1.Name = "Node0";
            treeNode1.Tag = "100";
            treeNode1.Text = "Login";
            treeNode2.Name = "Node1";
            treeNode2.Tag = "0";
            treeNode2.Text = "Clock On";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(350, 454);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDate);
            this.groupBox2.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(677, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Today\'s Date";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(51, 34);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(144, 34);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "DateLabel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(697, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Time Left For EOD";
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimeLeft.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.Location = new System.Drawing.Point(759, 194);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(103, 25);
            this.lblTimeLeft.TabIndex = 8;
            this.lblTimeLeft.Text = "Time Left";
            // 
            // pbOverAllCompletion
            // 
            this.pbOverAllCompletion.BackColor = System.Drawing.Color.Beige;
            this.pbOverAllCompletion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.pbOverAllCompletion.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbOverAllCompletion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pbOverAllCompletion.Location = new System.Drawing.Point(685, 300);
            this.pbOverAllCompletion.Minimum = 0;
            this.pbOverAllCompletion.Name = "pbOverAllCompletion";
            this.pbOverAllCompletion.ProgressColor = System.Drawing.Color.Green;
            this.pbOverAllCompletion.ProgressColor2 = System.Drawing.Color.Green;
            this.pbOverAllCompletion.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbOverAllCompletion.ShowText = true;
            this.pbOverAllCompletion.Size = new System.Drawing.Size(116, 116);
            this.pbOverAllCompletion.TabIndex = 9;
            this.pbOverAllCompletion.Text = "guna2CircleProgressBar1";
            // 
            // pbTaskProgress
            // 
            this.pbTaskProgress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.pbTaskProgress.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbTaskProgress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pbTaskProgress.Location = new System.Drawing.Point(820, 299);
            this.pbTaskProgress.Minimum = 0;
            this.pbTaskProgress.Name = "pbTaskProgress";
            this.pbTaskProgress.ProgressColor = System.Drawing.Color.Green;
            this.pbTaskProgress.ProgressColor2 = System.Drawing.Color.Green;
            this.pbTaskProgress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbTaskProgress.ShowText = true;
            this.pbTaskProgress.Size = new System.Drawing.Size(116, 116);
            this.pbTaskProgress.TabIndex = 10;
            this.pbTaskProgress.Text = "guna2CircleProgressBar2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(669, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Overall Completion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(816, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Task Progress";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnIncreaseProgress
            // 
            this.btnIncreaseProgress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncreaseProgress.FlatAppearance.BorderColor = System.Drawing.Color.Beige;
            this.btnIncreaseProgress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncreaseProgress.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncreaseProgress.Location = new System.Drawing.Point(768, 410);
            this.btnIncreaseProgress.Name = "btnIncreaseProgress";
            this.btnIncreaseProgress.Size = new System.Drawing.Size(89, 43);
            this.btnIncreaseProgress.TabIndex = 13;
            this.btnIncreaseProgress.Text = "Increase Progress";
            this.btnIncreaseProgress.UseVisualStyleBackColor = true;
            this.btnIncreaseProgress.Click += new System.EventHandler(this.btnIncreaseProgress_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAddTask;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(939, 455);
            this.Controls.Add(this.btnIncreaseProgress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbTaskProgress);
            this.Controls.Add(this.pbOverAllCompletion);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "To-do List Manager";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblquote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUncheckAllTasks;
        private System.Windows.Forms.Button btnCheckAllTasks;
        private System.Windows.Forms.Button btnRemoveAllTasks;
        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.Button btnAddSubTask;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTimeLeft;
        private Guna.UI2.WinForms.Guna2CircleProgressBar pbOverAllCompletion;
        private Guna.UI2.WinForms.Guna2CircleProgressBar pbTaskProgress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnIncreaseProgress;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

