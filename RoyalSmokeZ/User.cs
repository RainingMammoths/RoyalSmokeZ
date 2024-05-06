using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoyalSmokeZ
{
    internal class User
    {
        public string ID { get; set; } // ID of user
        public string Name { get; set; } // Name of Point of Sale
        public string Location { get; set; } // Location of Point of Sale
        public DateTime LastUpdate { get; set; } // Last update received

        public bool Received { get; set; } // Whether Z Account from previous day has been received

        public byte[] ZAccount; // The Z account of user
    }
}
