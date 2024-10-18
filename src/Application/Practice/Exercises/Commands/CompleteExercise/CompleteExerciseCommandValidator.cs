using FluentValidation;

namespace Application.Practice.Exercises.Commands.CompleteExercise;

public class CompleteExerciseCommandValidator : AbstractValidator<CompleteExerciseCommand>
{
    public CompleteExerciseCommandValidator()
    {
        RuleFor(c => c.ExerciseId.Value).NotEmpty();
        RuleFor(c => c.Answer).NotEmpty();
    }   
}