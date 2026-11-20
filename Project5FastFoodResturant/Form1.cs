using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project5FastFoodResturant
{
    public partial class Form1 : Form
    {
        clsOrder Order = new clsOrder();
        
        public Form1()
        {
            InitializeComponent();
            SeamlessNavigation(btnPizza, PizzaPanel);
        }

        private void SeamlessNavigation(Button button, Panel panel)
        {
            SidePanel.Height = button.Height;
            SidePanel.Top = button.Top;
            panel.BringToFront();
        }

        private void ResetForm()
        {
            Order = new clsOrder();
            lblOrderSummary.Text = "No Items Ordered Yet";
            lblPrice.Text = "$0";
        }

        private void ShowNotifyIcon()
        {
            string OrderNumber = Order.GenerateOrderNumber();
            Clipboard.SetText(OrderNumber);
            notifyIcon1.Icon = SystemIcons.Information;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Order has been sucessfully processed.";
            notifyIcon1.BalloonTipText = $"The order number is: {OrderNumber}. Copied To Clipboard.";
            notifyIcon1.ShowBalloonTip(1000);
        }


        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (lblOrderSummary.Text == "No Items Ordered Yet" || string.IsNullOrWhiteSpace(lblOrderSummary.Text))
            {
                MessageBox.Show("Please select some items to place an order");
                return;
            }
            if (MessageBox.Show($"Total Amount is: ${Order.Price}", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)
            {
                ShowNotifyIcon();
                ResetForm();
            }
        }

        private void AddItem(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Order.AddToListOfItems(button.Name, Convert.ToInt32(button.Tag));
            lblPrice.Text = "$" + Order.Price.ToString();
            lblOrderSummary.Text = Order.ItemsOrdered;
        }

        private void RemoveItem(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Order.RemoveFromListOfItems(button.Name, Convert.ToInt32(button.Tag));
            lblPrice.Text = "$" + Order.Price.ToString();
            lblOrderSummary.Text = Order.ItemsOrdered;
            if (string.IsNullOrWhiteSpace(lblOrderSummary.Text))
            {
                lblOrderSummary.Text = "No Items Ordered Yet";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit the application? ", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            SeamlessNavigation((Button)sender, PizzaPanel);
        }

        private void btnBurgers_Click(object sender, EventArgs e)
        {
            SeamlessNavigation((Button)sender, BurgersPanel);
        }

        private void btnSandwiches_Click(object sender, EventArgs e)
        {
            SeamlessNavigation((Button)sender, SandwichesPanel);
        }

        private void btnSalads_Click(object sender, EventArgs e)
        {
            SeamlessNavigation((Button)sender, SaladsPanel);
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            SeamlessNavigation((Button)sender, DrinksPanel);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            Form OrdersForm = new OrdersForm();
            OrdersForm.ShowDialog();
        }

    }
}
