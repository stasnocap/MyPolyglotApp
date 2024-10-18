using Domain.Common.Models;
using Domain.Practice.Lessons.ValueObjects;

namespace Domain.Practice.Scores.Events;

public record ScoreCreatedDomainEvent(Score Score) : IDomainEvent;