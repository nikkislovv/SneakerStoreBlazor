namespace SneakersApi.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection ConfigureCors(
          this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.SetIsOriginAllowed(_ => true)
                           .AllowAnyMethod()
                           .AllowCredentials()
                           .AllowAnyHeader());
            });

            return services;
        }
    }
}
