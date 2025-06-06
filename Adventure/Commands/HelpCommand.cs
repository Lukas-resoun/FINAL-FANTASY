using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Commands
{
    public class HelpCommand : BaseCommand
    {
        public override void Execute(World world, params string[] @params)
        {
            AnsiConsole.WriteLine("To interact with the game, use following commands ...");
            AnsiConsole.WriteLine("---");
            AnsiConsole.WriteLine("look - looks around the room");
            AnsiConsole.WriteLine("test - test the game");
            AnsiConsole.WriteLine("eat - your self?!");
            AnsiConsole.WriteLine("pick [current item name] - pick up current item");
            AnsiConsole.WriteLine("go [current room name] - go to current room");
            AnsiConsole.WriteLine("help - shows this help");
            AnsiConsole.WriteLine("quit - exits the game");
            AnsiConsole.WriteLine("inve - open inventory");
            AnsiConsole.WriteLine("inspect [current item name] - inspect an item");
            AnsiConsole.WriteLine("use [current item name] - use current item");
        }
    }
}
