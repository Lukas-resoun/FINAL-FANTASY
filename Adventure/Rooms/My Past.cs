using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Rooms
{
   public class My_Past : BaseRoom
   
    {
      
        public override string Name => "My_Past";

        public override string Description => "I am standing at streets of some futuristic city, and waiting on somebudy, but suddenly some witch comes in front of me and transform me in the beast. Beast that looked like spider with wings. The End";

        public override bool IsLocked { get; set; } = true;

        
    }
}
