using Domain.Common.Models;
using Domain.Practice.Lessons.ValueObjects;
using Domain.Practice.Scores.Events;
using Domain.Practice.Scores.ValueObjects;

namespace Domain.Practice.Scores;

public sealed class Score : AggregateRoot<ScoreId>
{
    public Rating Rating { get; }
    public Guid UserId { get; }
    public LessonId LessonId { get; }

    private Score(ScoreId id, Rating rating, Guid userId, LessonId lessonId) : base(id)
    {
        Rating = rating;
        UserId = userId;
        LessonId = lessonId;
    }

    private Score()
    {
    }

    public static Score Create(Guid userId, Rating rating, LessonId lessonId)
    {
        var score = new Score(ScoreId.CreateUnique(), rating, userId, lessonId);

        score.AddDomainEvent(new ScoreCreatedDomainEvent(score));

        return score;
    }
}