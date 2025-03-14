using Adventure.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Rooms
{
    public class Trophyroom : BaseRoom
      

    {
        public Trophyroom()
        {
            AddItem(new katana());
            AddItem(new Amulet());

        }
        
        public override string Name => "Trophyroom";

        public override string Description => "Room with japanese looking trophies and mysterios witchcraft things";
    }
}
