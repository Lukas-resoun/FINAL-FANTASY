using Adventure.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Rooms
{
    public class Secret_Time_Lair : BaseRoom
    { 
        public Secret_Time_Lair() 
        {
            AddItem(new Time_Machine_Ellon());
        }
        
        public override string Name => "Secret_Time_Lair";

        public override string Description => $"Secret Lair with motives of time And Giant Clocks on walls and {string.Join(",", items)} in the Middle.";

        public override bool IsLocked { get; set; } = true;
    }
}
   
