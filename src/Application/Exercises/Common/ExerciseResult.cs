using Domain.Exercises.ValueObjects;
using Domain.Lessons.ValueObjects;

namespace Application.Exercises.Common;

public record ExerciseResult(ExerciseId ExerciseId, RusPhrase RusPhrase, EngPhrase EngPhrase, IReadOnlyList<IReadOnlyList<string>> WordGroup);