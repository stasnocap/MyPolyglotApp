﻿using Application.Common.Interfaces.Persistence;
using Application.Common.Interfaces.Persistence.Identity;
using Application.Common.Interfaces.Persistence.Practice;
using Application.Common.Interfaces.Persistence.Vocabulary;
using Application.Common.Interfaces.Services;
using Domain.Identity;
using Infrastructure.Persistence;
using Infrastructure.Persistence.Configurations.Interceptors;
using Infrastructure.Persistence.Repositories;
using Infrastructure.Persistence.Repositories.Identity;
using Infrastructure.Persistence.Repositories.Practice;
using Infrastructure.Persistence.Repositories.Vocabulary;
using Infrastructure.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddAuth(configuration);
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        services.AddHttpContextAccessor();
        
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        
        services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));
        services.AddScoped<IExerciseRepository, ExerciseRepository>();
        services.AddScoped<ILessonRepository, LessonRepository>();
        services.AddScoped<IVocabularyRepository, VocabularyRepository>();
        services.AddScoped<IComparisonAdjectiveRepository, ComparisonAdjectiveRepository>();
        services.AddScoped<INounRepository, NounRepository>();
        services.AddScoped<IVerbRepository, VerbRepository>();
        services.AddScoped<IPrimaryVerbRepository, PrimaryVerbRepository>();
        services.AddScoped<ILetterNumberRepository, LetterNumberRepository>();
        services.AddScoped<IModalVerbRepository, ModalVerbRepository>();
        services.AddScoped<IAdverbRepository, AdverbRepository>();
        services.AddScoped<ICompoundRepository, CompoundRepository>();
        services.AddScoped<INumberWithNounRepository, NumberWithNounRepository>();
        services.AddScoped<IPronounRepository, PronounRepository>();
        services.AddScoped<IScoreRepository, ScoreRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        
        services.AddScoped<IUserContext, UserContext>();
        services.AddPostgresDatabase(configuration);
        return services;
    }

    private static void AddPostgresDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Database");
        if (string.IsNullOrWhiteSpace(connectionString))
        {
            throw new ArgumentNullException(nameof(connectionString), "Database connection string can't be empty.");
        }

        services.AddScoped<PublishDomainEventsInterceptor>();
        services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString));
    }

    private static IServiceCollection AddAuth(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddRoles<IdentityRole<Guid>>()
            .AddEntityFrameworkStores<AppDbContext>();

        return services;
    }
}