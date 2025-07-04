namespace WebShop.Domain.Models;

public class Cart : BaseEntity
{
    // Koszyk może mieć właściciela ale nie musi (niezalogowany użytkownik - temporary koszyk)
    public int? CustomerId { get; set; }
    public Customer? Customer { get; set; } = null!;

    // Lista pozycji w koszyku
    public ICollection<CartItem> Items { get; set; } = new List<CartItem>();

    ////// Data ostatniej modyfikacji koszyka
    ////public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
}
