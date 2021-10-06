using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeShipModels
{
    class Package
    {
        public int Id { get; set; }
        public Shipment Shipment { get; set; }
        public decimal Weight { get; set; }
        public string Description { get; set; }
    }
}
