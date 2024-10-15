using Web.Common.Mapping;

namespace Web;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services, IWebHostEnvironment environment)
    {
        services.AddControllers();
        services.AddMappings();
        
        var mvcBuilder = services.AddRazorPages();

        if (environment.IsDevelopment())
        {
            mvcBuilder.AddRazorRuntimeCompilation();
        }

        return services;
    }
}