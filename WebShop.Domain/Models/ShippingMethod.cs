using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Domain.Models
{
    public class ShippingMethod : BaseEntity
    {
        // Nazwa metody wysyłki, np. "InPost", "Poczta Polska", "DHL"
        public string Name { get; set; } = string.Empty;

        // Kod identyfikujący przewoźnika lub konkretną metodę, np. "INPOST", "DPD"
        public string CarrierCode { get; set; } = string.Empty;

        // Opcjonalny opis metody wysyłki
        public string? Description { get; set; }

        // Koszt wysyłki związany z tą metodą
        public decimal? Cost { get; set; }

        // Przybliżony czas dostawy, np. reprezentowany jako TimeSpan
        public TimeSpan? EstimatedDeliveryTime { get; set; }

        ////// Pole konfiguracyjne dla integracji z API przewoźnika (np. endpoint lub klucz)
        ////public string? ApiEndpoint { get; set; }

        // Nawigacja do zamówień, które wybrały tę metodę wysyłki (opcjonalne)
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }

}
