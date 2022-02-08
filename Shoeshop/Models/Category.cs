using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Shoeshop.Models
{
    public partial class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    
    }
}
