using Application.Practice.Exercises.Commands.CompleteExercise;
using Application.Practice.Exercises.Common;
using Application.Practice.Exercises.Queries.GetExercise;
using Application.Practice.Exercises.Queries.GetRandomExercise;
using Contracts.Exercises.Requests;
using Contracts.Exercises.Responses;
using Domain.Practice.Exercises.ValueObjects;
using Domain.Practice.Lessons.ValueObjects;
using Mapster;

namespace Web.Areas.Practice.Common.Mapping;

public class ExerciseMappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<GetRandomExerciseRequest, GetRandomExerciseQuery>()
            .Map(dest => dest.LessonId, src => LessonId.Create(src.LessonId));

        config.NewConfig<GetExerciseRequest, GetExerciseQuery>()
            .Map(dest => dest.LessonId, src => LessonId.Create(src.LessonId))
            .Map(dest => dest.ExerciseId, src => ExerciseId.Create(src.ExerciseId));

        config.NewConfig<CompleteExerciseRequest, CompleteExerciseCommand>()
            .Map(dest => dest.ExerciseId, src => ExerciseId.Create(src.ExerciseId))
            .Map(dest => dest.LessonId, src => LessonId.Create(src.LessonId));

        config.NewConfig<ExerciseResult, ExerciseResponse>()
            .Map(dest => dest.RusPhrase, src => src.RusPhrase.Value)
            .Map(dest => dest.ExerciseId, src => src.ExerciseId.Value);
    }
}