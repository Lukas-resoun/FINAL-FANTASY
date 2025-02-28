using Adventure.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Rooms
{
    public class Badroom1 : BaseRoom
   
    {
        public Badroom1() 
        {
            AddItem(new Letter());
        }
        public override string Name => "Badroom";

        public override string Description => $"Large Badroom, with Big bed and large painting aboth with mysterios Woman, who looks like a witch and a {string.Join(",", items)} on a desk";
    }
}
