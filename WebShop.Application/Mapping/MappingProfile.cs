using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using WebShop.Application.ViewModels.Customer;
using WebShop.Domain.Models;

namespace WebShop.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerForListVm>();

            CreateMap<Customer, CustomerDetailsVm>()
                .ForMember(dest => dest.CustomerFullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                .ForMember(dest => dest.CEOFullName, opt => opt.MapFrom(src => $"{src.CEOName} {src.CEOLastName}"))
                .ForMember(dest => dest.Addresses, opt => opt.MapFrom(src => src.Addresses));
        }
    }
}
