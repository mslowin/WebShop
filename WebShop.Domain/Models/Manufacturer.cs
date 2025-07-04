namespace WebShop.Domain.Models;

public class Manufacturer : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Slug { get; set; } = string.Empty;
    public ICollection<Product> Products { get; set; } = new List<Product>();
}
