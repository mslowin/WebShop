using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Domain.Models
{
    public class Cart : BaseEntity
    {
        // Powiązanie koszyka z klientem
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;

        // Lista pozycji w koszyku
        public ICollection<CartItem> Items { get; set; } = new List<CartItem>();

        ////// Data ostatniej modyfikacji koszyka
        ////public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
    }
}
