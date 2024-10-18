namespace Contracts.Exercises.Requests;

public record GetExerciseRequest(Guid ExerciseId, Guid LessonId);