using Application.Common.Interfaces.Persistence.Practice;
using Application.FunctionalTests.Abstractions;
using Domain.Practice.Exercises.ValueObjects;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;

namespace Application.FunctionalTests.Persistence.Repositories.Vocabulary.ExerciseRepository;

public class GetAnswerTests(FunctionalTestWebAppFactory functionalTestWebAppFactory) : BaseFunctionalTest(functionalTestWebAppFactory)
{
    [Fact]
    public async Task ShouldReturnCorrectAnswer_IfProvidedExistingExerciseId()
    {
        var exerciseRepository = Services.GetRequiredService<IExerciseRepository>();
        var exerciseId = ExerciseId.Create(Guid.Parse("6ed88863-0c5d-45cd-b361-3071bf62a907"));

        var answer = await exerciseRepository.GetAnswerAsync(exerciseId, CancellationToken.None);

        answer.Should().NotBeNull();
        answer.Should().Be("You will not see.");
    }
    
    [Fact]
    public async Task ShouldReturnNull_IfProvidedNonExistingExerciseId()
    {
        var exerciseRepository = Services.GetRequiredService<IExerciseRepository>();
        var exerciseId = ExerciseId.Create(Guid.Parse("11111111-0c5d-45cd-b361-3071bf62a907"));

        var answer = await exerciseRepository.GetAnswerAsync(exerciseId, CancellationToken.None);

        answer.Should().BeNull();
    }
}