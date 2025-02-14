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
            var item = world.CurrentRoom.items.FirstOrDefault(i => i.Name == @params[0]);
            world.CurrentRoom.RemoveItem(item);
        }
    }
}
