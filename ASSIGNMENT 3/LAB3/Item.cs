using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    internal class Item
    {
        static List<Item> items = new List<Item>();
        public int number { get; set; }
        public string date { get; set; }
        public int SKU { get; set; }
        public string item_name { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }

        public void save()
        {
            items.Add(this);
        }

        public static List<Item> getAllItems()
        {
            return items;
        }

    }
}
