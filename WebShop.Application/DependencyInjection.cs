using System.Reflection;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using WebShop.Application.Interfaces;
using WebShop.Application.Mapping;
using WebShop.Application.Services;

namespace WebShop.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddAutoMapper(typeof(MappingProfile));
            return services;
        }
    }
}
