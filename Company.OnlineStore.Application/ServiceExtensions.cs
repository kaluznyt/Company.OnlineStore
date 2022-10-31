using Company.OnlineStore.Application.Order.PlaceOrder;
using Microsoft.Extensions.DependencyInjection;

namespace Company.OnlineStore.Application
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<PlaceOrderUseCase>();

            return services;
        }
    }
}
