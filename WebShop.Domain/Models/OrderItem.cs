namespace WebShop.Domain.Models;

// Tworzony na podstawie zawartości koszyka, w momencie składania zamówienia.
// Jest niezmienny — historia zamówienia musi być trwała nawet jeśli później cena produktu się zmieni.
public class OrderItem : BaseEntity
{
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; } // Cena jednostkowa w momencie zakupu

    public int OrderId { get; set; }
    public Order Order { get; set; } = null!;

    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;
}
