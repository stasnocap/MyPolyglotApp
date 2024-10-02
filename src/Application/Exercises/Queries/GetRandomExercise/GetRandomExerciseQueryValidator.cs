using FluentValidation;

namespace Application.Exercises.Queries.GetRandomExercise;

public class GetRandomExerciseQueryValidator : AbstractValidator<GetRandomExerciseQuery>
{
    public GetRandomExerciseQueryValidator()
    {
        RuleFor(x => x.LessonId.Value).NotEmpty();
    }
}