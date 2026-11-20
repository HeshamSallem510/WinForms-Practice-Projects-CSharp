using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3QuizzApp
{
    public partial class Form1 : Form
    {
        public string TheDifficulty;
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectDifficulty(RadioButton btn)
        {
            if (btn.Checked)
            {
                btnplay.Enabled = true;
                TheDifficulty = btn.Text;
            }
            else
            {
                btnplay.Enabled = false;
            }
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            Form2 nextform = new Form2();
            nextform.StartPosition = FormStartPosition.Manual;
            nextform.Location = this.Location;
            nextform.Difficulty = TheDifficulty;
            nextform.Show();
            this.Hide();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            SelectDifficulty((RadioButton)sender);
        }
    }
}
