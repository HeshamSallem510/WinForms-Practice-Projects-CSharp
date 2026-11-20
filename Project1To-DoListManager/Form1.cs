using Project1To_DoListManager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1To_DoListManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartUp();
        }


        private void StartUp()
        {
            ChangeTodayMessage();
            GetTodayDate();
            UpdateTime();
            CheckProgressAndSetFocus();
        }

        private void CheckProgressAndSetFocus()
        {
            UpdateOverAllCompletionProgressBar();
            SetFocusToTxtTask();
            CheckIfFinished();
        }

        private void SetFocusToTxtTask()
        {
            txtTask.Focus();
        }

        private void UpdateOverAllCompletionProgressBar()
        {
            double CurrentValue = 0;
            int nodecount = treeView1.Nodes.Count;
            if (nodecount == 0) return;
            foreach (TreeNode node in treeView1.Nodes)
            {
                CurrentValue += Convert.ToInt32(node.Tag);
            }
            double Progress = (CurrentValue / (nodecount * 100)) * 100;
            pbOverAllCompletion.Value = (int)Progress;
        }
        private void UpdateTime()
        {
            DateTime now = DateTime.Now;
            DateTime endofday = DateTime.Today.AddDays(1);
            TimeSpan Difference = endofday - now;
            lblTimeLeft.Text = Difference.ToString(@"hh\:mm\:ss");
        }

        private void GetTodayDate()
        {
            DateTime dateTime = DateTime.Now;
            lblDate.Text = dateTime.ToShortDateString();
        }

        private void ChangeTodayMessage()
        {
            string[] Quotes =
            {
                "May your day be filled with joy, love, and laughter. Have a wonderful day!",
                "Wishing you a day as bright and beautiful as your smile.",
                "Sending you sunshine to brighten your day and positive vibes to lift your spirits!",
                "Every day is a new chance to shine. Make today amazing!",
                "Start the day with a smile, and the rest of the day will follow with happiness. Have a great day!",
                "May today bring you peace, happiness, and the strength to conquer whatever comes your way.",
                "Rise and shine! The world is waiting for your magic.",
                "Let this day be a canvas of possibilities. Paint it with your best colors!",
                "Sending you good vibes and a little bit of sunshine to brighten your day.",
                "May your day be filled with positive thoughts, kind people, and unforgettable moments."
            };
            Random rnd = new Random();
            lblquote.Text = Quotes[rnd.Next(0, Quotes.Length - 1)];
        }

        private void CheckIfFinished()
        {
            if (pbOverAllCompletion.Value == 100)
            {
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.BalloonTipTitle = "Congrats!";
                notifyIcon1.BalloonTipText = "That is a job well done! Grab a coffee and celeberate!";
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            pbTaskProgress.Value = Convert.ToInt32(e.Node.Tag);
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Checked)
                e.Node.Tag = 100;
            else
                e.Node.Tag = 0;
            pbTaskProgress.Value = Convert.ToInt32(e.Node.Tag);
            CheckAllChildItems(e.Node, e.Node.Checked);
            CheckProgressAndSetFocus();
        }

        private void CheckAllChildItems(TreeNode Node, Boolean IsChecked)
        {
            foreach (TreeNode Item in Node.Nodes)
            {
                Item.Checked = IsChecked;
                //if (Item.Checked)
                //    Item.Tag = 100;
                //else
                //    Item.Tag = 0;
                if (Item.Nodes.Count > 0)
                {
                    this.CheckAllChildItems(Item, IsChecked);
                }
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTask.Text))
            {
                errorProvider1.SetError(txtTask, "Please enter the task name.");
                SetFocusToTxtTask();
                return;
            }
            else
            {
                TreeNode treeNode = new TreeNode(txtTask.Text);
                treeNode.Tag = 0;
                treeView1.Nodes.Add(treeNode);
            }
            txtTask.Clear();
            CheckProgressAndSetFocus();
        }

        private void btnAddSubTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTask.Text))
            {
                errorProvider1.SetError(txtTask, "Please enter the subtask name.");
                SetFocusToTxtTask();
                treeView1.SelectedNode = null;
                return;
            }
            if (treeView1.SelectedNode != null)
            {
                if (treeView1.SelectedNode.Text == "Login" || treeView1.SelectedNode.Text == "Clock On")
                {
                    MessageBox.Show("You cannot add a subtask to this task.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    treeView1.SelectedNode.Nodes.Add(txtTask.Text);
                    CheckAllChildItems(treeView1.SelectedNode, treeView1.SelectedNode.Checked);
                    txtTask.Clear();
                }

            }
            else
            {
                MessageBox.Show("Please select a task to add a sub task to.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            treeView1.SelectedNode = null;
            SetFocusToTxtTask();
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                if (treeView1.SelectedNode.Text == "Login" || treeView1.SelectedNode.Text == "Clock On")
                {
                    MessageBox.Show("This task cannot be removed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    treeView1.SelectedNode.Remove();
            }
            else
            {
                MessageBox.Show("Please select a task to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            treeView1.SelectedNode = null;
            CheckProgressAndSetFocus();
        }

        private void btnRemoveAllTasks_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete All Tasks", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)
            {
                TreeNode Node = treeView1.Nodes[0];
                TreeNode Node2 = treeView1.Nodes[1];
                treeView1.Nodes.Clear();
                treeView1.Nodes.Add(Node);
                treeView1.Nodes.Add(Node2);
            }
            CheckProgressAndSetFocus();
        }

        private void btnCheckAllTasks_Click(object sender, EventArgs e)
        {
            foreach (TreeNode Node in treeView1.Nodes)
            {
                Node.Checked = true;
                Node.Tag = 100;
            }
            CheckProgressAndSetFocus();
        }

        private void btnUncheckAllTasks_Click(object sender, EventArgs e)
        {
            foreach (TreeNode Node in treeView1.Nodes)
            {
                Node.Checked = false;
                Node.Tag = 0;
            }
            treeView1.Nodes[0].Checked = true;
            treeView1.Nodes[0].Tag = 100;
            CheckProgressAndSetFocus();
        }

        private void btnIncreaseProgress_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null)
                return;
            else
            {
                int TagValue = Convert.ToInt32(treeView1.SelectedNode.Tag);
                if (TagValue == 100)
                {
                    return;
                }
                TagValue += 10;
                treeView1.SelectedNode.Tag = TagValue;
                pbTaskProgress.Value = TagValue;
                if (TagValue == 100)
                    treeView1.SelectedNode.Checked = true;
            }
            CheckProgressAndSetFocus();
        }


    }

}
