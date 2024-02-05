using Microsoft.Extensions.DependencyInjection;

namespace IoC.ServiceInjectors
{
    public static class CrossCutting
    {
        public static void AddServiceExtentions(this IServiceCollection service)
        {
            //service.AddScoped<Service>();
        }
    }
}
