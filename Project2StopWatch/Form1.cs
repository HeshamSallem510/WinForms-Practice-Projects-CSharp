using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2StopWatch
{ 
    public partial class Form1 : Form
    {
        TimeInfo TheTime;
        TimeInfo TheLapInfo;
        TimeInfo BiggestLap;
        struct TimeInfo
        {
            public byte NumberOfSeconds;
            public byte NumberOfMinutes;
            public byte NumberOfHours;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            TheTime.NumberOfSeconds = 0;
            TheTime.NumberOfMinutes = 0;
            TheTime.NumberOfHours = 0;
            TheLapInfo.NumberOfSeconds = 0;
            TheLapInfo.NumberOfMinutes = 0;
            TheLapInfo.NumberOfHours = 0;
            lbltime.Text = "00:00:00";
        }

        private void btnlap_Click(object sender, EventArgs e)
        {
            string LapTime = MakeLapTime();
            ListViewItem item;
            if (listView1.Items.Count == 0)
            {
                item = new ListViewItem("Lap1");
            }
            else
            {
                item = new ListViewItem($"Lap{listView1.Items.Count + 1}");
            }
            item.SubItems.Add(LapTime);
            if (IsBiggestLap())
            {
                UpdateAllItemsColors();
                item.ForeColor = Color.Blue;
            }
            //check then change color of item
            listView1.Items.Add(item);
            ResetLapTime();
        }

        private void UpdateAllItemsColors()
        {
            if (listView1.Items.Count > 0)
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    item.ForeColor = Color.IndianRed;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TheTime.NumberOfSeconds++;
            TheLapInfo.NumberOfSeconds++;
            UpdateLapTime();
            UpdateTime();
            UpdateTimeLabel();
        }
        
        private void UpdateBiggestLapLabel()
        {
            if (BiggestLap.NumberOfHours >= 10)
                lblbiggestlap.Text = $"{BiggestLap.NumberOfHours}:";
            else
                lblbiggestlap.Text = $"0{BiggestLap.NumberOfHours}:";
            if (BiggestLap.NumberOfMinutes >= 10)
                lblbiggestlap.Text += $"{BiggestLap.NumberOfMinutes}:";
            else
                lblbiggestlap.Text += $"0{BiggestLap.NumberOfMinutes}:";
            if (BiggestLap.NumberOfSeconds >= 10)
                lblbiggestlap.Text += $"{BiggestLap.NumberOfSeconds}";
            else
                lblbiggestlap.Text += $"0{BiggestLap.NumberOfSeconds}";
        }

        private void UpdateBiggestLap()
        {
            BiggestLap.NumberOfHours = TheLapInfo.NumberOfHours;
            BiggestLap.NumberOfMinutes = TheLapInfo.NumberOfMinutes;
            BiggestLap.NumberOfSeconds = TheLapInfo.NumberOfSeconds;
            UpdateBiggestLapLabel();
        }

        private bool IsBiggestLap()
        {
            
            //don't forget to update biggest lap variable with biggest one
            if (TheLapInfo.NumberOfHours > BiggestLap.NumberOfHours)
            {
                UpdateBiggestLap();
                return true;
            }
            if (TheLapInfo.NumberOfMinutes > BiggestLap.NumberOfMinutes)
            {
                UpdateBiggestLap();
                return true;
            }
            if (TheLapInfo.NumberOfSeconds > BiggestLap.NumberOfSeconds)
            {
                UpdateBiggestLap();
                return true;
            }

            return false;
        }
        private void ResetLapTime()
        {
            TheLapInfo.NumberOfSeconds = 0;
            TheLapInfo.NumberOfMinutes = 0;
            TheLapInfo.NumberOfHours = 0;
        }
        private void UpdateLapTime()
        {
            if (TheLapInfo.NumberOfSeconds == 60)
            {
                TheLapInfo.NumberOfMinutes++;
                if (TheLapInfo.NumberOfMinutes == 60)
                {
                    TheLapInfo.NumberOfHours++;
                    TheLapInfo.NumberOfMinutes = 0;
                }
                TheLapInfo.NumberOfSeconds = 0;
            }
        }
        private void UpdateTime()
        {
            if (TheTime.NumberOfSeconds == 60)
            {
                TheTime.NumberOfMinutes++;
                if (TheTime.NumberOfMinutes == 60)
                {
                    TheTime.NumberOfHours++;
                    TheTime.NumberOfMinutes = 0;
                }
                TheTime.NumberOfSeconds = 0;
            }
        }

        private string MakeLapTime()
        {
            string LapTime = "";
            if (TheLapInfo.NumberOfHours >= 10)
                LapTime = $"{TheLapInfo.NumberOfHours}:";
            else
                LapTime = $"0{TheLapInfo.NumberOfHours}:";
            if (TheLapInfo.NumberOfMinutes >= 10)
                LapTime += $"{TheLapInfo.NumberOfMinutes}:";
            else
                LapTime += $"0{TheLapInfo.NumberOfMinutes}:";
            if (TheLapInfo.NumberOfSeconds >= 10)
                LapTime += $"{TheLapInfo.NumberOfSeconds}";
            else
                LapTime += $"0{TheLapInfo.NumberOfSeconds}";
            return LapTime;
        }

        private void UpdateTimeLabel()
        {
            if (TheTime.NumberOfHours >= 10)
                lbltime.Text = $"{TheTime.NumberOfHours}:";
            else
                lbltime.Text = $"0{TheTime.NumberOfHours}:";
            if (TheTime.NumberOfMinutes >= 10)
                lbltime.Text += $"{TheTime.NumberOfMinutes}:";
            else
                lbltime.Text += $"0{TheTime.NumberOfMinutes}:";
            if (TheTime.NumberOfSeconds >= 10)
                lbltime.Text += $"{TheTime.NumberOfSeconds}";
            else
                lbltime.Text += $"0{TheTime.NumberOfSeconds}";
        }

    }
}

