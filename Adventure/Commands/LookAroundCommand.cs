using Adventure.Rooms;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Commands
{
    public class LookAroundCommand : BaseCommand
    {
        public override void Execute(World world, params string[] @params)
        {
            AnsiConsole.MarkupLine($"You looked around and see a [green]{world.CurrentRoom.Description}[/]");
            AnsiConsole.MarkupLine($"You also see [green]{string.Join(", ", world.CurrentRoom.items)}[/]");
            AnsiConsole.MarkupLine($"and You also see [green]{string.Join(", ", world.CurrentRoom.neighbours)}[/]");
        }
    }
}
