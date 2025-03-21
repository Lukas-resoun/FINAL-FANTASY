using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Commands
{
    public class InventoryCommand : BaseCommand
    {
        public override void Execute(World Inventory, params string[] @params)
        {
            AnsiConsole.MarkupLine($"you have [green]{string.Join(", ", Inventory.Inventory.items)}[/]");
        }
        
    }
}
