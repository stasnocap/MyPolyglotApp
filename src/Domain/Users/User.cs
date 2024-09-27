using Domain.Common.Models;
using Domain.Scores.ValueObjects;
using Domain.Users.Events;
using Domain.Users.ValueObjects;

namespace Domain.Users;

public sealed class User : AggregateRoot<UserId>
{
    private readonly List<ScoreId> _scoreIds = new();

    public FirstName FirstName { get; }
    public LastName LastName { get; }
    public Email Email { get; }
    public PasswordHash PasswordHash { get; set; } = null!;
    public IReadOnlyList<ScoreId> ScoreIds => _scoreIds.AsReadOnly();

    private User(UserId id, FirstName firstName, LastName lastName, Email email) : base(id)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }

    public static User Create(FirstName firstName, LastName lastName, Email email)
    {
        var user = new User(UserId.CreateUnique(), firstName, lastName, email);
        
        user.AddDomainEvent(new UserCreatedDomainEvent(user));

        return user;
    }
    
    public void AddScore(ScoreId scoreId)
    {
        _scoreIds.Add(scoreId);
    }
}