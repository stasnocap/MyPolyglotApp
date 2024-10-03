using Web;
using Application;
using Infrastructure;
using Web.Common.Extensions;

var builder = WebApplication.CreateBuilder(args);

{
    builder.Services
        .AddApplication()
        .AddInfrastructure(builder.Configuration)
        .AddPresentation();
}

var app = builder.Build();
{
    app.ApplyMigrations();
    
    app.UseHttpsRedirection();
    app.UseStaticFiles();
    app.UseAuthentication();
    app.UseAuthorization();
    
    var mapControllers = app.MapControllers();
    if (!builder.Environment.IsDevelopment())
    {
        mapControllers.RequireAuthorization();
    }
    
    app.MapRazorPages();
    app.Run();
}

public partial class Program;