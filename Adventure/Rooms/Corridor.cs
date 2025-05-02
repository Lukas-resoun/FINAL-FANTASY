﻿using Adventure.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Rooms
{
    public class Corridor : BaseRoom

    {
        
        public override string Name => "Corridor";

        public override string Description => "dark and empty corridor";

        public override bool IsLocked { get; set; } = true;
    }
}
