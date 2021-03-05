using Microsoft.Extensions.DependencyInjection;

namespace OnionArcExample.Application
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection serviceCollection)
        {
            return serviceCollection;
        }
    }
}