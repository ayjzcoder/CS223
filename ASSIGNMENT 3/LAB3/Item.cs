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
        public int Id { get; set; }
        public string date { get; set; }
        public int SKU { get; set; }
        public string item_name { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }

        public bool isAvailable { get; set; }

        public string shipping{ get; set; }

        public string payment { get; set; } 


        public void save()
        {
            items.Add(this);
        }

        public static List<Item> getAllItems()
        {
            return items;
        }

        public static List<Item> search(string name)
        {
            return items.FindAll(item => item.item_name.ToLower() == name.ToLower());

           
        }
       
        

    }
}
