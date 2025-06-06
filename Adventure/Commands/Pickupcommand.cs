using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Commands
{
    internal class Pickupcommand : BaseCommand
    {
        public override void Execute(World world, params string[] @params)
        {
            if (!@params.Any())
            {
                AnsiConsole.MarkupLine($"you must enter what you want to pick");
                return;
            }

            var item = world.CurrentRoom.items.FirstOrDefault(i => i.Name == @params[0]);

            if (item == null)
            {
                AnsiConsole.MarkupLine("[mediumpurple2] Wtf, this item donť exist.[/]");
                return;
            }

            world.Inventory.AddItem(item);
            world.CurrentRoom.RemoveItem(item);
          
        }
    }
}
