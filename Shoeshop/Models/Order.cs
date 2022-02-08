using System;
using System.Collections.Generic;

#nullable disable

namespace Shoeshop.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public int? OrderCostumerId { get; set; }
        public string OrderDate { get; set; }
        public int? OrderShipment { get; set; }
        public int? OrderPayment { get; set; }
        public decimal? TotalPrice { get; set; }
    }
}
