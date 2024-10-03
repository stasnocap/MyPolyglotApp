using Domain.Practice.Exercises;
using Domain.Practice.Lessons.ValueObjects;
using ErrorOr;
using MediatR;

namespace Application.Practice.Exercises.Queries.GetRandomExercise;

public record GetRandomExerciseQuery(LessonId LessonId) : IRequest<ErrorOr<Exercise>>;