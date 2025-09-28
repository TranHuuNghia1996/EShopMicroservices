namespace Ordering.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services)
        {
            // Add API services and configurations here
            return services;
        }


        public static WebApplication UseApiServices(this WebApplication app)
        {
            // Configure the HTTP request pipeline here
            return app;
        }
    }
}
