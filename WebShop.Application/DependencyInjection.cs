using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using WebShop.Application.Interfaces;
using WebShop.Application.Services;

namespace WebShop.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
