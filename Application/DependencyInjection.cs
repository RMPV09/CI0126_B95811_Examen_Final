using Application.Sodas;
using Application.Sodas.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            //services.AddTransient<ISodaService, SodaService>();
            return services;
        }
    }
}
