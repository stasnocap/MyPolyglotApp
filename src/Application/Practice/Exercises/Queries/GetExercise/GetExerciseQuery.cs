using Application.Practice.Exercises.Common;
using Domain.Practice.Exercises.ValueObjects;
using Domain.Practice.Lessons.ValueObjects;
using MediatR;
using ErrorOr;

namespace Application.Practice.Exercises.Queries.GetExercise;

public record GetExerciseQuery(ExerciseId ExerciseId, LessonId LessonId) : IRequest<ErrorOr<ExerciseResult>>;