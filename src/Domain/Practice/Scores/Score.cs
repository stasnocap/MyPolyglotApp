using Domain.Common.Models;
using Domain.Practice.Exercises.ValueObjects;
using Domain.Practice.Lessons.ValueObjects;
using Domain.Practice.Scores.Events;
using Domain.Practice.Scores.ValueObjects;

namespace Domain.Practice.Scores;

public sealed class Score : AggregateRoot<ScoreId>, IHasDomainEvents
{
    public ScoreValue ScoreValue { get; }
    public Guid UserId { get; }
    public LessonId LessonId { get; }

    private Score(ScoreId id, ScoreValue scoreValue, Guid userId, LessonId lessonId) : base(id)
    {
        ScoreValue = scoreValue;
        UserId = userId;
        LessonId = lessonId;
    }

    public static Score Create(Guid userId, LessonId lessonId)
    {
        var score = new Score(ScoreId.CreateUnique(), ScoreValue.Create(), userId, lessonId);
        
        score.AddDomainEvent(new ScoreCreatedDomainEvent(score));
        
        return score;
    }
}