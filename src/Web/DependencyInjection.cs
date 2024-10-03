using Web.Common.Mapping;

namespace Web;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddMappings();
        services.AddRazorPages();
        return services;
    }
}