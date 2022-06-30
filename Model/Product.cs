using System;
using System.Collections.Generic;

namespace WindowsForms.Model
{
    public partial class Product
    {
        public string ModelId { get; set; } = null!;
        public string? ProductName { get; set; }
        public string? Manufacturer { get; set; }
        public DateTime? ManDate { get; set; }
        public decimal? Price { get; set; }
        public bool? Availability { get; set; }
    }
}
