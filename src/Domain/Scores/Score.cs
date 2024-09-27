using Domain.Common.Models;
using Domain.Scores.ValueObjects;
using Domain.Users.ValueObjects;

namespace Domain.Scores;

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