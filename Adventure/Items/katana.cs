using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items
{
    public class katana : BaseItem
    {
        public override string Name => "Katana";

        public override string Description => "very long decorated katana, with decorated writting on it that says Masamune";


        public override void Use(World world)
        {
            var room = world.CurrentRoom.neighbours.FirstOrDefault(n => n.IsLocked);

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
