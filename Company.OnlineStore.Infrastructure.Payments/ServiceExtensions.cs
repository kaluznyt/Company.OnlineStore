using Company.OnlineStore.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace Company.OnlineStore.Infrastructure.Payments
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddInfrastructurePayments(this IServiceCollection services)
        {
            
            services.AddScoped<IPaymentService, PaymentService>();

            return services;
        }
    }
}
