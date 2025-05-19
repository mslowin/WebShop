using WebShop.Domain.Models.Enums;

namespace WebShop.Domain.Models;

public class Order : BaseEntity
{
    public string OrderNumber { get; set; } = string.Empty;
    public DateTime OrderDate { get; set; } = DateTime.UtcNow;
    public OrderStatus Status { get; set; } = OrderStatus.Pending;
    public decimal TotalGross { get; set; } // suma wszystkiego brutto
    public decimal TotalNet { get; set; } // suma wszystkiego netto
    public decimal TaxAmount { get; set; }
    public string? TrackingNumber { get; set; } // numer śledzenia przesyłki

    public int PaymentMethodId { get; set; }
    public PaymentMethod PaymentMethod { get; set; } = null!;

    public int ShippingMethodId { get; set; }
    public ShippingMethod ShippingMethod { get; set; } = null!;

    public int CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;

    public int ShippingAddressId { get; set; }
    public Address ShippingAddress { get; set; } = null!;

    public int BillingAddressId { get; set; }
    public Address BillingAddress { get; set; } = null!;

    public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();
}
