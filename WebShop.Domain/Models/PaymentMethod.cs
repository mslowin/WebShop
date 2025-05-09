using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Domain.Models
{
    public class PaymentMethod : BaseEntity
    {
        // Nazwa metody płatności, np. "Credit Card", "PayPal", "Bank Transfer"
        public string Name { get; set; } = string.Empty;

        // Unikalny kod identyfikujący metodę płatności w systemie, np. "CREDIT_CARD", "PAYPAL", "BANK_TRANSFER"
        public string MethodCode { get; set; } = string.Empty;

        // Opcjonalny opis, który może zawierać dodatkowe informacje o metodzie płatności
        public string? Description { get; set; }

        ////// Endpoint API lub inne dane konfiguracyjne, użyteczne przy integracji z zewnętrznymi systemami płatniczymi
        ////public string? ApiEndpoint { get; set; }

        // Opcjonalnie opłata transakcyjna związaną z tą metodą, np. jako procent lub wartość stała
        public decimal? TransactionFee { get; set; }

        // Zamówienia, które wybrały tę metodę płatności
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
