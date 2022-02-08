using System;
using System.Collections.Generic;

#nullable disable

namespace Shoeshop.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public int? ProductCategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal? ProductPrice { get; set; }
        public string ProductInfo { get; set; }
    }
}
