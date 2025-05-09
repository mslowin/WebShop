using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Domain.Models.Enums;

namespace WebShop.Domain.Models
{
    public class Address : BaseEntity
    {
        public string Country { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string BuildingNumber { get; set; } = string.Empty;
        public string? ApartmentNumber { get; set; }
        public string PostalCode { get; set; } = string.Empty;
        public AddressType Type { get; set; } = AddressType.Shipping;

        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
    }
}
