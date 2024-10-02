using Domain.Scores.ValueObjects;
using Microsoft.AspNetCore.Identity;

namespace Domain.Users;

public sealed class User : IdentityUser<Guid>
{
    private readonly List<ScoreId> _scoreIds = new();

    public IReadOnlyList<ScoreId> ScoreIds => _scoreIds.AsReadOnly();
    
    public void AddScore(ScoreId scoreId)
    {
        _scoreIds.Add(scoreId);
    }
}