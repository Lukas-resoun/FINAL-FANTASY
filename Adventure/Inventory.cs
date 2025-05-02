using Adventure.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class Inventory
    {
        public List<BaseItem> items = new List<BaseItem>();

        public void AddItem(BaseItem item)
        {
            items.Add(item);
        }
        public void RemoveItem(BaseItem item)
        {
            items.Remove(item);
        }
        //public void UseItem(string itemName)
        //{
        //    var item = items.FirstOrDefault(i => i.Name.ToLower() == itemName.ToLower());
        //    if (item != null)
        //    {
        //        item.Use();
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{itemName} se v inventáři nenachází.");
        //    }
        //}

        public void ShowInventory()
        {
            Console.WriteLine("Obsah inventáře:");
            foreach (var item in items)
            {
                Console.WriteLine($"- {item.Name}: {item.Description}");
            }
        }

    }
   
}
