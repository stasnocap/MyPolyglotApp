using Domain.Common.Models;

namespace Domain.Identity.Events;

public record UserCreatedDomainEvent(User User) : IDomainEvent;