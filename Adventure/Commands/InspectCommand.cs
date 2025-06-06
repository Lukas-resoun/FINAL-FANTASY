using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Commands
{
    public class InspectCommand : BaseCommand
    {
        public override void Execute(World world, params string[] @params)
        {
            if (!@params.Any())
            {
                AnsiConsole.MarkupLine($"you must enter what to use");
                return;
            }

            var item = world.Inventory.items.FirstOrDefault(n => n.Name == @params[0]);

            if (item == null)
            {
                AnsiConsole.MarkupLine("[red] Wtf, this item donť exist.[/]");
                return;
            }

            AnsiConsole.MarkupLine($"This item is:{string.Join(",", item.Description)}");
        }
    }
}
