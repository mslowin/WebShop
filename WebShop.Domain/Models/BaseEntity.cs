namespace WebShop.Domain.Models;

public class BaseEntity
{
    public int Id { get; set; }
    public string? CreatedBy { get; set; } = null;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public bool IsDeleted { get; set; } = false;
}
