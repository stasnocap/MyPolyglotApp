namespace Contracts.Exercises.Requests;

public record CompleteExerciseRequest(Guid ExerciseId, Guid LessonId, string Answer);