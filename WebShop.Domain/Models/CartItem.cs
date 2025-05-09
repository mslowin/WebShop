using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Domain.Models
{
    // Reprezentuje produkt dodany do koszyka, ale jeszcze niezamówiony,
    // jest powiązany z konkretnym Cart i może być zmieniany przez użytkownika (dodawanie, usuwanie, zmiana ilości).
    public class CartItem : BaseEntity
    {
        // Ilość wybranego produktu
        public int Quantity { get; set; }

        // Cena jednostkowa może być kopiowana z encji produktu, 
        // aby zachować historyczną wartość ceny w momencie dodania do koszyka
        public decimal UnitPrice { get; set; }

        // Powiązanie z koszykiem, do którego należy dana pozycja
        public int CartId { get; set; }
        public Cart Cart { get; set; } = null!;

        // Pozycja koszykowa odnosi się do konkretnego produktu
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}
