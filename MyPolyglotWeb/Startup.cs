using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Models.ViewModels;
using MyPolyglotWeb.Presentations;
using MyPolyglotWeb.Models;
using MyPolyglotWeb.Repositories.IRepositories;
using System;
using MyPolyglotCore.Words;
using MyPolyglotWeb.Repositories;
using MyPolyglotWeb.Services.IServices;
using MyPolyglotWeb.Services;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using MyPolyglotCore.Interfaces;
using MyPolyglotCore;

namespace MyPolyglotWeb
{
    public class Startup
    {
        public const string AuthMethod = "CoockieAuth";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<WebContext>(
                 options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddAuthentication(AuthMethod)
                .AddCookie(AuthMethod, config =>
                {
                    config.Cookie.Name = "User.Auth";
                    config.LoginPath = "/User/Login";
                    config.AccessDeniedPath = "/User/AccessDenied";
                });
            services.AddControllersWithViews();
            RegisterPresentation(services);
            RegisterRepository(services);
            RegisterMapper(services);
            RegisterServices(services);
            services.AddHttpContextAccessor();
            services.AddScoped(x => new Random());
            services.AddScoped<IRecognizer>(x => new Recognizer());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        private void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IUserService>(x => new UserService(
                x.GetService<IUserRepository>(),
                x.GetService<IHttpContextAccessor>()
            ));
        }

        private void RegisterMapper(IServiceCollection services)
        {
            var config = new MapperConfiguration(x =>
            {
                x.CreateMap<AddExerciseVM, ExerciseDB>();
                x.CreateMap<UnrecognizedWordVM, UnrecognizedWordDB>()
                    .ForMember(nameof(UnrecognizedWordDB.Id), x => x.MapFrom(x => x.UnrecognizedWordId))
                    .ReverseMap();
                x.CreateMap<UnrecognizedWordDB, Word>()
                    .ConvertUsing(x => CastUnrecognizedWordDBToWord(x));
                x.CreateMap<ExerciseDB, DoExerciseVM>()
                    .ForMember(nameof(DoExerciseVM.ExerciseId), x => x.MapFrom(x => x.Id));
                x.CreateMap<Word, UnrecognizedWordVM>();
                x.CreateMap<List<ExerciseDB>, AllExercisesVM>()
                    .ForMember(nameof(AllExercisesVM.Exercises), x => x.MapFrom(x => x));
                x.CreateMap<ExerciseDB, ExerciseVM>()
                    .ForMember(nameof(ExerciseVM.ExerciseId), x => x.MapFrom(x => x.Id));
                x.CreateMap<ExerciseVM, ExerciseDB>()
                    .ForMember(nameof(ExerciseDB.Id), x => x.MapFrom(x => x.ExerciseId))
                    .ForMember(nameof(ExerciseDB.UnrecognizedWords), x => x.Ignore())
                    .ForMember(nameof(ExerciseDB.Lesson), x => x.Ignore());
                x.CreateMap<RegisterUserVM, UserDB>();
            });
            services.AddScoped(x => config.CreateMapper());
        }

        private Word CastUnrecognizedWordDBToWord(UnrecognizedWordDB word)
        {
            return word.Type switch
            {
                UnrecognizableTypes.Adjective => new Adjective(word.Text),
                UnrecognizableTypes.Noun => new Noun(word.Text, word.WasRecognizedFromPluralForm),
                UnrecognizableTypes.RegularVerb => new Verb(word.Text),
                UnrecognizableTypes.RegularComparisonAdjective => new ComparisonAdjective(word.Text, word.SyllablesInRegularComparisonAdjective),
                _ => throw new NotImplementedException()
            };
        }

        private void RegisterRepository(IServiceCollection services)
        {
            services.AddScoped<ILessonRepository>(x => new LessonRepository(
                x.GetService<WebContext>()
            ));

            services.AddScoped<IExerciseRepository>(x => new ExerciseRepository(
                x.GetService<WebContext>(),
                x.GetService<Random>()
            ));

            services.AddScoped<IUserRepository>(x => new UserRepository(
                x.GetService<WebContext>()
            ));

            services.AddScoped<IScoreRepository>(x => new ScoreRepository(
                x.GetService<WebContext>()
            ));

            services.AddScoped<IUnrecognizedWordRepository>(x => new UnrecognizedWordRepository(
                x.GetService<WebContext>()
            ));
        }

        private void RegisterPresentation(IServiceCollection services)
        {
            services.AddScoped(x => new HomePresentation(
                x.GetService<IMapper>(),
                x.GetService<IExerciseRepository>(),
                x.GetService<IUserService>(),
                x.GetService<IScoreRepository>(),
                x.GetService<ILessonRepository>()
            ));
            services.AddScoped(x => new AdminPresentation(
                x.GetService<IMapper>(),
                x.GetService<ILessonRepository>(),
                x.GetService<IExerciseRepository>(),
                x.GetService<IUnrecognizedWordRepository>(),
                x.GetService<IRecognizer>()
            ));
            services.AddScoped(x => new UserPresentation(
                x.GetService<IUserRepository>(),
                x.GetService<IMapper>()
            ));
        }
    }
}
