using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items
{
    public class Gunblade : BaseItem
    {
        public override string Name => "Gunblade";

        public override string Description => "Hybrid between gun and sword, with something look like lion carving on it ";

        
        public override void Use(World world)
        {
            var room = world.CurrentRoom.neighbours.FirstOrDefault(n => n.IsLocked && n.Name =="Secret_Time_Lair");

            if (room == null)
            {
                AnsiConsole.MarkupLine("[red] It´s no use.[/]");
                return;
            }

            room.IsLocked = false;

            var item = world.Inventory.items.FirstOrDefault(i => i.Name == Name);
            world.Inventory.RemoveItem(item);
        }
    }
}
