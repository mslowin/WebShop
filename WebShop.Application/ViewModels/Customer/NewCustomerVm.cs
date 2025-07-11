using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Application.ViewModels.Customer
{
    public class NewCustomerVm
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Nip { get; set; } = string.Empty;
        public string REGON { get; set; } = string.Empty;
    }
}
