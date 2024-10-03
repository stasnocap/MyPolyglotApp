using Domain.Common.Models;
using Domain.Practice.Exercises.ValueObjects;
using Domain.Practice.Lessons.ValueObjects;
using Domain.Practice.Scores.ValueObjects;
using ErrorOr;

namespace Domain.Practice.Lessons;

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

    public static ErrorOr<Lesson> Create(LessonId lessonId, LessonNumber number, LessonName name)
    {
        return new Lesson(lessonId, number, name);
    }

    public void AddExercise(ExerciseId exerciseId)
    {
        _exerciseIds.Add(exerciseId);
    }

    public void AddExercises(IReadOnlyList<ExerciseId> exerciseIds)
    {
        _exerciseIds.AddRange(exerciseIds);
    }

    public void AddScore(ScoreId scoreId)
    {
        _scoreIds.Add(scoreId);
    }
}