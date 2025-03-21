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

    }
   
}
