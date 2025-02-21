using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Commands
{
    public class Gocommand : BaseCommand
    {
        public override void Execute(World world, params string[] @params)
        {
            
            if (!@params. Any())
            {
                AnsiConsole.MarkupLine($"you must enter where you go");
                return;
            }

            var room = world.CurrentRoom.neighbours. FirstOrDefault(n => n.Name == @params[0]);

            if (room == null )
            {
                AnsiConsole.MarkupLine("[mediumpurple2] Wtf, this room donť exist.[/]");
                return;
            }

            world.SwitchRoom(room);
            
                
            






        }
    }
}
