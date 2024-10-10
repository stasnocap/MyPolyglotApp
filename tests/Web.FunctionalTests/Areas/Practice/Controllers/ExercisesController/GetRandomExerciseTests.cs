using System.Net;
using System.Net.Http.Json;
using Contracts.Exercises.Responses;
using Domain.Practice.Lessons.Errors;
using FluentAssertions;
using Infrastructure.Persistence.Seed.Practice;
using Microsoft.AspNetCore.Mvc;
using Web.FunctionalTests.Abstractions;

namespace Web.FunctionalTests.Areas.Practice.Controllers.ExercisesController;

public class GetRandomExerciseTests(FunctionalTestWebAppFactory factory) : BaseFunctionalTest(factory)
{
    [Fact]
    public async Task ShouldGetRandomExercise_WhenProvidedCorrectLessonId()
    {
        var response = await HttpClient.GetAsync($"exercises/random/{LessonSeed.LessonId1.Value}");
        
        // assert
        
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        
        var jsonModel = await response.Content.ReadFromJsonAsync<ExerciseResponse>();
        
        jsonModel.Should().NotBeNull();
        jsonModel!.ExerciseId.Should().NotBeEmpty();
        jsonModel.RusPhrase.Should().NotBeNullOrWhiteSpace();
        jsonModel.WordGroups.Should().NotBeNull();

        foreach (var wordGroup in jsonModel.WordGroups)
        {
            wordGroup.Should().NotBeNull();
            wordGroup.Words.Count.Should().BeGreaterThan(0);
            wordGroup.Type.Should().NotBe(ExerciseResponse.WordType.None);
        }
    }
    
    [Fact]
    public async Task ShouldReturnNotFound_WhenProvidedIncorrectLessonId()
    {
        var response = await HttpClient.GetAsync("exercises/random/10000000-0000-0000-0000-000000000000");
        
        // assert
        
        response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        
        var jsonModel = await response.Content.ReadFromJsonAsync<ProblemDetails>();
        
        jsonModel.Should().NotBeNull();
        jsonModel!.Detail.Should().Be(LessonErrors.NotFound.Description);
    }
}