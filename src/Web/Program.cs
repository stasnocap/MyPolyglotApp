using Web;
using Application;
using Infrastructure;

var builder = WebApplication.CreateBuilder(args);

{
    builder.Services
        .AddApplication()
        .AddInfrastructure(builder.Configuration)
        .AddPresentation();
}

var app = builder.Build();
{
    app.UseExceptionHandler("/error");
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