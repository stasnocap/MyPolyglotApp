using Domain.Practice.Exercises.ValueObjects;

namespace Application.Practice.Exercises.Commands.CompleteExercise;

public record CompleteExerciseResult(bool Success, string CorrectAnswer, ExerciseId ExerciseId);