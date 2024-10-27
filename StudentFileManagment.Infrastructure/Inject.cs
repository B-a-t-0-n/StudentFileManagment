using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentFileManagement.Infrastructure;

namespace StudentFileManagment.Infrastructure
{
    public static class Inject
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<DataContext>();
            return services;
        }
    }
}
