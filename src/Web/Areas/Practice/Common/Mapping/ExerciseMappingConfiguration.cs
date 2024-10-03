using Application.Practice.Exercises.Queries.GetRandomExercise;
using Contracts.Exercises.Requests;
using Contracts.Exercises.Responses;
using Domain.Practice.Exercises;
using Domain.Practice.Lessons.ValueObjects;
using Mapster;

namespace Web.Areas.Practice.Common.Mapping;

public class ExerciseMappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<GetRandomExerciseRequest, GetRandomExerciseQuery>()
            .Map(dest => dest.LessonId, src => LessonId.Create(src.LessonId));

        config.NewConfig<Exercise, ExerciseResponse>()
            .Map(dest => dest.RusPhrase, src => src.RusPhrase.Value)
            .Map(dest => dest.ExerciseId, src => src.Id.Value);

    }
}