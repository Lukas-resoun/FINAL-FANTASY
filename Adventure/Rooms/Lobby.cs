using Adventure.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Rooms
{
    public class Lobby : BaseRoom
    {
        public Lobby()
        {
            AddItem(new Rock());
        }
        public override string Description => $"Dim looby with {string.Join(",", items)}";

        public override string Name => "Lobby";
    }
}
    
