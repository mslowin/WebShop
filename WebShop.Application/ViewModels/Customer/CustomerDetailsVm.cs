using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using WebShop.Application.Mapping;
using WebShop.Application.ViewModels.Address;
using WebShop.Domain.Models;

namespace WebShop.Application.ViewModels.Customer
{
    public class CustomerDetailsVm
    {
        public int Id { get; set; }
        public string CustomerFullName { get; set; } = string.Empty;
        public string CEOFullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; }
        public string? CompanyName { get; set; }
        public string? Nip { get; set; }
        public string Regon { get; set; } = string.Empty;
        public byte[] LogoPic { get; set; } = [];
        public List<AddressForListVm> Addresses { get; set; } = [];
    }
}
