using System;
using System.Collections.Generic;

#nullable disable

namespace Shoeshop.Models
{
    public partial class Shipment
    {
        public int Id { get; set; }
        public decimal? ShipmentPrice { get; set; }
    }
}
