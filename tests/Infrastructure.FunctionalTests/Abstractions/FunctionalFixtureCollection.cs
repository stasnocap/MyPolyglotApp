namespace Application.FunctionalTests.Abstractions;

[CollectionDefinition(nameof(FunctionalFixtureCollection))]
public class FunctionalFixtureCollection : ICollectionFixture<FunctionalTestWebAppFactory>;