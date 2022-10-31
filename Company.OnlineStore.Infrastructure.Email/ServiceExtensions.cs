using Company.OnlineStore.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace Company.OnlineStore.Infrastructure.Email
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddInfrastructureEmail(this IServiceCollection services)
        {
            services.AddScoped<INotificationService, EmailNotificationService>();

            return services;
        }
    }
}
