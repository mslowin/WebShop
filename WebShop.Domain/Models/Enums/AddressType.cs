using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Domain.Models.Enums
{
    public enum AddressType
    {
        Shipping, // adres dostawy - adres, na który ma zostać dostarczony produkt
        Billing // adres rozliczeniowy - adres, który widnieje na fakturze lub paragonie
    }
}
