using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items
{
    public class Time_Machine_Ellon : BaseItem
    {
        public override string Name => "Time_Machine_Ellon";

        public override string Description => "Mysterios Headset, with carving on it that sayes: Time Machine Ellon.";

        public override void Use(World world)
        {
            var room = world.CurrentRoom.neighbours.FirstOrDefault(n => n.IsLocked && n.Name == "My_Past");

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
