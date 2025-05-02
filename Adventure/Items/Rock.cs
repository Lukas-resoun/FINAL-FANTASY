using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items
{
    public class Rock : BaseItem
    {
        public override string Name => "Rock";

        public override string Description => "Very dull, very heavy rock";

        public override void Use(World world)
        {
            var room = world.CurrentRoom.neighbours.FirstOrDefault(n => n.IsLocked);

            room.IsLocked = false;

            var item = world.Inventory.items.FirstOrDefault(i => i.Name == Name);
            world.Inventory.RemoveItem(item);
        }
    }
}
