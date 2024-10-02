using ErrorOr;
using Web.Common.Mapping;
using Web.Common.Http;

namespace Web;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddMappings();
        services.AddProblemDetails(options =>
        {
            options.CustomizeProblemDetails = context =>
            {
                if (context.HttpContext.Items[HttpContextItemKeys.Errors] is List<Error> errors)
                {
                    context.ProblemDetails.Extensions.Add("errorCodes", errors.Select(e => e.Code));
                }
            };
        });
        return services;
    }
}