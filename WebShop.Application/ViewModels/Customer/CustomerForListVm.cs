using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using WebShop.Application.Mapping;
using WebShop.Domain.Models;

namespace WebShop.Application.ViewModels.Customer
{
    public class CustomerForListVm
    {
        public int Id { get; set; }
        public string? CompanyName { get; set; }
        public string? Nip { get; set; }
    }
}
