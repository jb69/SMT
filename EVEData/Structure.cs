﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMT.EVEData
{
    class Structure
    {
        public enum UpwellType
        {
            // citadel
            Astrahus,
            Fortizar,
            FactionFortizar,
            Keepstar,

            // engineering
            Raitaru,
            Azbel,
            Sotiyo,

            // refineries
            Athanor,
            Tatara,
            NPC_Station,
        }

        public enum PowerState
        {
            Normal,
            LowPower,
            Shield,
            Armor,
        }

        public string ID { get; set; }
        public string Name { get; set; }
        public string System { get; set; }
        public DateTime LastUpdate { get; set; }
        public PowerState State { get; set; }
        public UpwellType Type { get; set; }
    }
}
