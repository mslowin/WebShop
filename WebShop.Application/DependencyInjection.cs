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
            // Add services to the container.
            services.AddTransient<ICustomerService, CustomerService>();

            // Register AutoMapper
            services.AddAutoMapper(typeof(MappingProfile));
            return services;
        }
    }
}
