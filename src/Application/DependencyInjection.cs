using System.Reflection;
using Application.Common.Behaviours;
using Application.Practice.Exercises.Common;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(options => { options.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly); });

        services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
        services.AddScoped(typeof(IPipelineBehavior<,>), typeof(UnitOfWorkBehaviour<,>));

        services.AddScoped<ExerciseConverter>();
        
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        return services;
    }
}