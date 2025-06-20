using Adventure.Rooms;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items
{
    internal class Sword : BaseItem
    { 
        public override string Name => "Sword";

        public override string Description => "Very Big and sharp golden sword, with mysterious writing on it, that sayes Somnia tua amplectere et honorem tuum ut miles protege. ";

        public override void Use(World world)
        {
            var room = world.CurrentRoom.neighbours.FirstOrDefault(n => n.IsLocked && n.Name== "Badroom");

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
