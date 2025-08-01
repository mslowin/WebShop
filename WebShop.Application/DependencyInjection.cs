using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using WebShop.Application.Interfaces;
using WebShop.Application.Mapping;
using WebShop.Application.Services;
using WebShop.Application.Validators.Customer;
using WebShop.Application.ViewModels.Customer;

namespace WebShop.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            // Add services to the container.
            services.AddTransient<IItemService, ItemService>();
            services.AddTransient<ICustomerService, CustomerService>();

            // Register AutoMapper
            services.AddAutoMapper(typeof(MappingProfile));

            // Register FluentValidation validators
            services.AddScoped<IValidator<NewCustomerVm>, NewCustomerValidator>();
            return services;
        }
    }
}
