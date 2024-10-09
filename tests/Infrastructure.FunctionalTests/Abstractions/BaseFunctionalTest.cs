using Microsoft.Extensions.DependencyInjection;

namespace Application.FunctionalTests.Abstractions;

[Collection(nameof(FunctionalFixtureCollection))]
public class BaseFunctionalTest(FunctionalTestWebAppFactory functionalTestWebAppFactory) : IAsyncLifetime
{
    public FunctionalTestWebAppFactory FunctionalTestWebAppFactory { get; } = functionalTestWebAppFactory;

    private IServiceScope _scope = null!;

    public IServiceProvider Services => _scope.ServiceProvider;

    public Task InitializeAsync()
    {
        _scope = FunctionalTestWebAppFactory.Services.CreateScope();
        return Task.CompletedTask;
    }

    public Task DisposeAsync()
    {
        _scope.Dispose();
        return Task.CompletedTask;
    }
}