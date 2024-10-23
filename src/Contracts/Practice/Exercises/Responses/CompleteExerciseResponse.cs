namespace Contracts.Exercises.Responses;

public record CompleteExerciseResponse(bool Success, string CorrectAnswer, Guid ExerciseId);