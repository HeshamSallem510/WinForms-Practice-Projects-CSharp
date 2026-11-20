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
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
            DisplayOrders();
        }

        private void DisplayOrders()
        {
            foreach (var key in clsOrder._PreviousOrders)
            {
                ListViewItem item = new ListViewItem(key.Value.ToString());
                item.SubItems.Add(key.Key.ItemsOrdered.ToString());
                item.ImageIndex = 0;
                listView1.Items.Add(item);
            }
        }
    }
}
