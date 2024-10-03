﻿namespace Web.FunctionalTests.Abstractions;

public class BaseFunctionalTest(FunctionalTestWebAppFactory factory) : IClassFixture<FunctionalTestWebAppFactory>
{
    protected HttpClient HttpClient { get; } = factory.CreateClient();
}