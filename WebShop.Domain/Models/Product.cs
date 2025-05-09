using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Domain.Models
{
    // Główny katalogowy byt. Przechowuje dane o produkcie w sklepie. Jest punktem odniesienia zarówno dla koszyka, jak i zamówienia
    public class Product : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal PriceGross { get; set; }
        public decimal PriceNet { get; set; }
        public int StockQuantity { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } = null!;

        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; } = null!;

        public ICollection<ProductImage> Images { get; set; } = new List<ProductImage>();

        public ICollection<ProductAttribute> Attributes { get; set; } = new List<ProductAttribute>();
    }
}
