using DataServices;
using Interfaces;

namespace NathanDelivery.Services
{
    public static class DataServicesConfiguration
    {

        public static void AddDataServices(this IServiceCollection services)
        {
            services.AddTransient<IClienteService, ClienteService>();
        }






    }
}
