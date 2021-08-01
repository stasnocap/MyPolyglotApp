using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyPolyglotWeb.MapperProfiles;
using MyPolyglotWeb.Presentation;
using MyPolyglotWeb.Repositories;
using MyPolyglotWeb.Repositories.IRepository;
using System;

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
        }

        private void RegisterMapper(IServiceCollection services)
        {
            var config = new MapperConfiguration(x => {
                x.AddProfile<TestProfile>();
            });
            services.AddScoped<IMapper>(x => new Mapper(config));
        }

        private void RegisterRepository(IServiceCollection services)
        {
            services.AddScoped<ILessonRepository>(x => new LessonRepository(
                x.GetService<WebContext>()));
        }

        private void RegisterPresentation(IServiceCollection services)
        {
            services.AddScoped(x => new HomePresentation());
            services.AddScoped(x => new AdminPresentation(
                x.GetService<ILessonRepository>()));
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
