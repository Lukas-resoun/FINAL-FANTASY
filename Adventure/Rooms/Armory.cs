using Adventure.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Rooms
{
    public class Armory : BaseRoom
    
    {
        public Armory()
        {
            AddItem(new Sword());
            AddItem(new Shield());

        }
        public override string Name => "Armory";

        public override string Description => "solid armory with solid gear";
    }
}
