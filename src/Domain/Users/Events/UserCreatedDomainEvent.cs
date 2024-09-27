using Domain.Common.Models;

namespace Domain.Users.Events;

public record UserCreatedDomainEvent(User User) : IDomainEvent;