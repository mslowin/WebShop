namespace WebShop.Domain.Models;

public class Customer : BaseEntity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string? PhoneNumber { get; set; }
    public string? CompanyName { get; set; }
    public string? Nip { get; set; }
    public string Regon { get; set; } = string.Empty;
    public string CEOName { get; set; } = string.Empty;
    public string CEOLastName { get; set; } = string.Empty;
    public byte[] LogoPic { get; set; } = [];


    public Cart? Cart { get; set; }

    public ICollection<Order> Orders { get; set; } = new List<Order>();
    public ICollection<Address> Addresses { get; set; } = new List<Address>();
}
