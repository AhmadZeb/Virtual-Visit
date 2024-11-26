using VirtualVisit.Application.Interfaces;
using VirtualVisit.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace VirtualVisit.Infrastructure
{
    public static class ServiceCollectionExtension
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IContactRepository, ContactRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
