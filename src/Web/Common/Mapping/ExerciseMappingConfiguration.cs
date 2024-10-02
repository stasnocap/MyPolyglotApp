using Application.Exercises.Common;
using Application.Exercises.Queries.GetRandomExercise;
using Contracts.Exercises.Requests;
using Contracts.Exercises.Responses;
using Domain.Lessons.ValueObjects;
using Mapster;

namespace Web.Common.Mapping;

public class ExerciseMappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<GetRandomExerciseRequest, GetRandomExerciseQuery>()
            .Map(dest => dest.LessonId, src => LessonId.Create(src.LessonId));

        config.NewConfig<ExerciseResult, ExerciseResponse>()
            .Map(dest => dest.EngPhrase, src => src.EngPhrase.Value)
            .Map(dest => dest.RusPhrase, src => src.RusPhrase.Value)
            .Map(dest => dest.ExerciseId, src => src.ExerciseId.Value);
    }
}