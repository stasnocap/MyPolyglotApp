using Domain.Common.Models;
using Domain.Exercises.ValueObjects;
using Domain.Lessons.ValueObjects;
using Domain.Scores.ValueObjects;
using ErrorOr;

namespace Domain.Lessons;

public sealed class Lesson : AggregateRoot<LessonId>
{
    private readonly List<ExerciseId> _exerciseIds = [];
    private readonly List<ScoreId> _scoreIds = [];
    
    public LessonNumber Number { get; }
    public LessonName Name { get; }
    public IReadOnlyList<ExerciseId> ExerciseIds => _exerciseIds.AsReadOnly();
    public IReadOnlyList<ScoreId> ScoreIds => _scoreIds.AsReadOnly();

    protected Lesson(LessonId id, LessonNumber number, LessonName name) : base(id)
    {
        Number = number;
        Name = name;
    }

    public static ErrorOr<Lesson> Create(LessonNumber number, LessonName name)
    {
        return new Lesson(LessonId.CreateUnique(), number, name);
    }

    public void AddExercise(ExerciseId exerciseId)
    {
        _exerciseIds.Add(exerciseId);
    }

    public void AddScore(ScoreId scoreId)
    {
        _scoreIds.Add(scoreId);
    }
}