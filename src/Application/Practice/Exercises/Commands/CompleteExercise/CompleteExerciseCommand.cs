using Domain.Practice.Exercises.ValueObjects;
using Domain.Practice.Lessons.ValueObjects;
using MediatR;
using ErrorOr;

namespace Application.Practice.Exercises.Commands.CompleteExercise;

public record CompleteExerciseCommand(ExerciseId ExerciseId, LessonId LessonId, string Answer) : IRequest<ErrorOr<CompleteExerciseResult>>;