using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5FastFoodResturant
{

    internal class clsOrder
    {
        internal int Price { get; private set; }
        internal string ItemsOrdered { get; private set; }

        private static Random rnd = new Random();

        internal static Dictionary<clsOrder, long> _PreviousOrders = new Dictionary<clsOrder, long>();

        private Dictionary<string, int> _Items = new Dictionary<string, int>();

        private void UpdateItemsOrdered()
        {
            ItemsOrdered = "";
            foreach (var item in _Items)
            {
                if (item.Value > 1)
                {
                    ItemsOrdered += $", x{item.Value}{item.Key}";
                }
                else
                {
                    ItemsOrdered += $", {item.Key}";
                }

            }
            ItemsOrdered = ItemsOrdered.TrimStart(',').Trim();
        }

        private void AddToPrice(int price)
        {
            Price += price;
        }

        private void RemoveFromPrice(int price)
        {
            if (Price == 0)
                return;
            Price -= price;
        }

        private void StoreOrderNumber(long OrderNumber)
        {
            _PreviousOrders.Add(this, OrderNumber);
        }

        public void AddToListOfItems(string ItemToBeAdded, int price)
        {
            string TheItem = ItemToBeAdded.Substring(6);
            if (_Items.ContainsKey(TheItem))
            {
                _Items[TheItem] += 1;
            }
            else
            {
                _Items.Add(TheItem, 1);
            }
            AddToPrice(price);
            UpdateItemsOrdered();
        }

        public void RemoveFromListOfItems(string ItemToBeRemoved, int price)
        {
            string TheItem = ItemToBeRemoved.Substring(9);
            if (_Items.ContainsKey(TheItem))
            {
                RemoveFromPrice(price);
                _Items[TheItem] -= 1;
                if (_Items[TheItem] <= 0)
                {
                    _Items.Remove(TheItem);
                }
                UpdateItemsOrdered();
            }
        }

        public string GenerateOrderNumber()
        {
            string OrderNumber = "35";
            for (int i = 0; i < 8; i++)
            {
                OrderNumber += Convert.ToString(rnd.Next(1, 9));
            }
            StoreOrderNumber(Convert.ToInt64(OrderNumber));
            return OrderNumber;
        }

    }
}
