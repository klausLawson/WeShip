using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeShipModels
{
    class Shipment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Client Client { get; set; }
        public Shipper Shipper { get; set; }
        public Receiver Receiver { get; set; }
        public DateTime pickupDt { get; set; }
        public DateTime DelivryDt { get; set; }
        public EnumAddressType Status  { get; set; }
        public IEnumerable packages { get; set; }
    }

}
