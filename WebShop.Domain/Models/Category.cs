namespace WebShop.Domain.Models;

public class Category : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Slug { get; set; } = string.Empty;
    public int? ParentCategoryId { get; set; }
    public Category? ParentCategory { get; set; }

    // Relacja podrzędna (Subcategories)
    public ICollection<Category> Subcategories { get; set; } = new List<Category>();

    // Produkty należące do tej kategorii
    public ICollection<Product> Products { get; set; } = new List<Product>();
}
