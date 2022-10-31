using Company.OnlineStore.Application;
using Company.OnlineStore.Application.Order;
using Company.OnlineStore.Application.ShoppingBasket;
using Microsoft.Extensions.DependencyInjection;

namespace Company.OnlineStore.Infrastructure.SqlServer
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddSqlServerRepositories(this IServiceCollection services)
        {
            services.AddScoped<IShoppingBasketRepository, ShoppingBasketRepository>();
            services.AddScoped<IReceiptRepository, ReceiptRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();

            return services;
        }
    }
}
