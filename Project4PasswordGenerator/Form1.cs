using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Project4PasswordGenerator
{
    public partial class PasswordGenerator : Form
    {
        enum enStrength { Easy = 1, Weak = 2, Good = 3, Strong = 4 };
        enStrength TheStrength;
        List<byte> CheckedItems = new List<byte>();
        Random rnd = new Random();
        public PasswordGenerator()
        {
            InitializeComponent();
            DetermineStrength();
            lblcharacters.Text = trackBar1.Value.ToString();
            GeneratePassword();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblPassword.Text))
            {
                MessageBox.Show("Please select a length.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Clipboard.SetText(lblPassword.Text);
                MessageBox.Show("Text copied to clipboard!", "Text Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private byte CountChecked()
        {
            byte Counter = 0;
            CheckedItems.Clear();
            foreach (Control control in Checkboxespanel.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    if (checkBox.Checked)
                    {
                        CheckedItems.Add(Convert.ToByte(checkBox.Tag));
                        Counter++;
                    }
                }
            }
            return Counter;
        }

        private void UpdateStrength()
        {
            int strengthvalue = (int)TheStrength;
            ProgressBar[] progressbar = {progressBar1, progressBar2, progressBar3, progressBar4}; 
            for (int i = 0; i < progressbar.Length; i++)
            {
                progressbar[i].Value = i < strengthvalue ? 100 : 0;
            }
            lblStrength.Text = TheStrength.ToString();
        }

        private void DetermineStrength()
        {
            byte checkedcount = CountChecked();
            if (trackBar1.Value >= 12 && checkedcount == 4)
            {
                TheStrength = enStrength.Strong;
            }
            else if (trackBar1.Value >= 8 && checkedcount >= 3)
            {
                TheStrength = enStrength.Good;
            }
            else if (trackBar1.Value >= 5 && checkedcount >= 2)
            {

                TheStrength = enStrength.Weak;
            }
            else
            {
                TheStrength = enStrength.Easy;
            }    
            UpdateStrength();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblcharacters.Text = trackBar1.Value.ToString();
            DetermineStrength();
        }

        private void ChangesToCheckBoxes(object sender, EventArgs e)
        {
            DetermineStrength();
        }

        private void GeneratePassword()
        {
            if (CheckedItems.Count == 0)
            {
                MessageBox.Show("You have to select an option to include.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblPassword.Text = "";
            int number = 0;
            for (int i = 0; i < trackBar1.Value; i++)
            {//Determines whether to generate uppercase, lowercase letters, symbols, or numbers.
                number = CheckedItems[rnd.Next(0, CheckedItems.Count)];
                switch (number)
                {
                    case 0:
                        lblPassword.Text += (char)rnd.Next(65, 91);
                        break;
                    case 1:
                        lblPassword.Text += (char)rnd.Next(97, 123);
                        break;
                    case 2:
                        lblPassword.Text += (char)rnd.Next(48, 58);
                        break;
                    case 3:
                        lblPassword.Text += (char)rnd.Next(33, 48);
                        break;
                }

            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GeneratePassword();
        }

        private void tsmShowTicks_Click(object sender, EventArgs e)
        {
            if (trackBar1.TickStyle == TickStyle.None)
            {
                trackBar1.TickStyle = TickStyle.BottomRight;
                tsmShowTicks.Text = "Hide Ticks";
            }
            else
            {
                trackBar1.TickStyle = TickStyle.None;
                tsmShowTicks.Text = "Show Ticks";
            }
        }
    }
}
