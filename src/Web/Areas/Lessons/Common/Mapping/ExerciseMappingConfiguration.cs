using Application.Exercises.Queries.GetRandomExercise;
using Contracts.Exercises.Requests;
using Contracts.Exercises.Responses;
using Domain.Exercises;
using Domain.Lessons.ValueObjects;
using Mapster;

namespace Web.Areas.Lessons.Common.Mapping;

public class ExerciseMappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<GetRandomExerciseRequest, GetRandomExerciseQuery>()
            .Map(dest => dest.LessonId, src => LessonId.Create(src.LessonId));

        config.NewConfig<Exercise, ExerciseResponse>()
            .Map(dest => dest.EngPhrase, src => src.EngPhrase.Value)
            .Map(dest => dest.RusPhrase, src => src.RusPhrase.Value)
            .Map(dest => dest.ExerciseId, src => src.Id.Value);

    }
}