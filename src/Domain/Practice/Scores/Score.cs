using Domain.Common.Models;
using Domain.Identity.ValueObjects;
using Domain.Practice.Scores.ValueObjects;

namespace Domain.Practice.Scores;

public sealed class Score : AggregateRoot<ScoreId>
{
    public ScoreValue ScoreValue { get; }
    public UserId UserId { get; }

    private Score(ScoreId id, ScoreValue scoreValue, UserId userId) : base(id)
    {
        ScoreValue = scoreValue;
        UserId = userId;
    }

    public static Score Create(UserId userId)
    {
        return new Score(ScoreId.CreateUnique(), ScoreValue.Create(), userId);
    }
}