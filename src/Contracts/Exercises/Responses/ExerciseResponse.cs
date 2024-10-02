namespace Contracts.Exercises.Responses;

public record ExerciseResponse(Guid ExerciseId, string RusPhrase, string EngPhrase, IReadOnlyList<IReadOnlyList<string>> WordGroup);