using FluentValidation;

namespace Application.Practice.Exercises.Queries.GetExercise;

public class GetExerciseQueryValidator : AbstractValidator<GetExerciseQuery>
{
    public GetExerciseQueryValidator()
    {
        RuleFor(q => q.ExerciseId.Value).NotEmpty();
        RuleFor(q => q.LessonId.Value).NotEmpty();
    }
}