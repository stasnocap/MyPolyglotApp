﻿using Domain.Practice.Exercises.ValueObjects;

namespace Application.Practice.Exercises.Common;

public record ExerciseResult(ExerciseId ExerciseId, RusPhrase RusPhrase, IReadOnlyList<ExerciseResult.WordGroup> WordGroups)
{
    public record WordGroup(IReadOnlyList<string> Words, WordType Type);
}