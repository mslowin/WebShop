namespace WebShop.Domain.Models;

public class ProductAttribute : BaseEntity
{
    // nazwa atrybutu, np. kolor, rozmiar, napięcie itp.
    public string Name { get; set; } = string.Empty;

    // wartość atrybutu, np. czerwony, XL, 230V itp.
    public string Value { get; set; } = string.Empty;

    public int ProductId { get; set; }
    public Product Product { get; set; } = null!;
}
