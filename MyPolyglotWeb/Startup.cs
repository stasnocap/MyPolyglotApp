using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Models.ViewModels;
using MyPolyglotWeb.Presentation;
using MyPolyglotWeb.Models;
using MyPolyglotWeb.Repositories.IRepository;
using System;
using MyPolyglotCore.Words;

namespace MyPolyglotWeb
{
    public class Startup
    {
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
            services.AddControllersWithViews();
            RegisterPresentation(services);
            RegisterRepository(services);
            RegisterMapper(services);
            services.AddScoped(x => new Random());
        }

        private void RegisterMapper(IServiceCollection services)
        {
            var config = new MapperConfiguration(x =>
            {
                x.CreateMap<AddExerciseVM, ExerciseDB>();
                x.CreateMap<UnrecognizedWordVM, UnrecognizedWordDB>().ReverseMap();
                x.CreateMap<UnrecognizedWordDB, Word>()
                    .ConvertUsing(x => CastUnrecognizedWordDBToWord(x));
                x.CreateMap<ExerciseDB, ExerciseVM>()
                    .ForMember(nameof(ExerciseVM.ExerciseId), x => x.MapFrom(x => x.Id));
                x.CreateMap<Word, UnrecognizedWordVM>();
            });
            services.AddScoped(x => config.CreateMapper());
        }

        private Word CastUnrecognizedWordDBToWord(UnrecognizedWordDB word)
        {
            return word.Type switch
            {
                MyPolyglotCore.UnrecognizableTypes.Adjective => new Adjective(word.Text),
                MyPolyglotCore.UnrecognizableTypes.Noun => new Noun(word.Text),
                MyPolyglotCore.UnrecognizableTypes.Verb => new Verb(word.Text),
                _ => throw new NotImplementedException()
            };
        }

        private void RegisterRepository(IServiceCollection services)
        {
            services.AddScoped<ILessonRepository>(x => new LessonRepository(
                x.GetService<WebContext>()));
            services.AddScoped<IExerciseRepository>(x => new ExerciseRepository(
                x.GetService<WebContext>(),
                x.GetService<Random>()));
        }

        private void RegisterPresentation(IServiceCollection services)
        {
            services.AddScoped(x => new HomePresentation(
                x.GetService<IMapper>(),
                x.GetService<IExerciseRepository>()));
            services.AddScoped(x => new AdminPresentation(
                x.GetService<IMapper>(),
                x.GetService<ILessonRepository>(),
                x.GetService<IExerciseRepository>()));
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
