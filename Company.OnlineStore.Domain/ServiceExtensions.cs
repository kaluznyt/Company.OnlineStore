using Microsoft.Extensions.DependencyInjection;

namespace Company.OnlineStore.Domain
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            return services;
        }
    }
}
