using System.Text;
using Domain.Practice.Exercises.ValueObjects;
using Domain.Practice.Lessons.ValueObjects;

namespace Application.Practice.Exercises.Common;

public record ExerciseResult(ExerciseId ExerciseId, LessonNumber LessonNumber, RusPhrase RusPhrase, IReadOnlyList<ExerciseResult.WordGroup> WordGroups)
{
    public record WordGroup(IReadOnlyList<string> Words, WordType Type);
}