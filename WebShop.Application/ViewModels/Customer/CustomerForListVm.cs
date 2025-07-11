using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using WebShop.Application.Mapping;

namespace WebShop.Application.ViewModels.Customer
{
    public class CustomerForListVm : IMapFrom<Domain.Models.Customer>
    {
        public int Id { get; set; }
        public string? CompanyName { get; set; }
        public string? Nip { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Models.Customer, CustomerForListVm>();
        }
    }
}
