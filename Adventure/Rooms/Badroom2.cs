using Adventure.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Rooms
{
    public class Badroom2 : BaseRoom
    {
        public Badroom2()
        {
            AddItem(new Gunblade());
        }
        public override string Name => "Badroom2";

        public override string Description => $"Another, badroom bud here on pickture is someone who looks like eggy a teenager with guneblade in his hand there is also the same {string.Join(",", items)} on wall";

        
    }
}
