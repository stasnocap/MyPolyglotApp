using Domain.Practice.Exercises;
using Domain.Practice.Exercises.ValueObjects;
using Domain.Practice.Lessons;
using Domain.Practice.Scores;

namespace Application.Practice.Exercises.Common;

public record ExerciseResult(Exercise Exercise, Lesson Lesson, Score? Score, IReadOnlyList<ExerciseResult.WordGroup> WordGroups)
{
    public record WordGroup(IReadOnlyList<string> Words, WordType Type);
}