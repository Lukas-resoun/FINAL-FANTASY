using Adventure.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Rooms
{
    public class Corridor : BaseRoom

    {
        public Corridor()
        {
            AddItem(new Sword());
        }
        public override string Name => "Corridor";

        public override string Description => "dark and empty corridor";
    }
}
