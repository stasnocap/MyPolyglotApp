using Domain.Common.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Infrastructure.Persistence.Configurations.Interceptors;

public class PublishDomainEventsInterceptor(IPublisher _publisher) : SaveChangesInterceptor
{
    public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
    {
        PublishDomainEvents(eventData.Context, CancellationToken.None).GetAwaiter().GetResult();
        return base.SavingChanges(eventData, result);
    }

    public override async ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = new CancellationToken())
    {
        await PublishDomainEvents(eventData.Context, cancellationToken);
        return await base.SavingChangesAsync(eventData, result, cancellationToken);
    }

    private async Task PublishDomainEvents(DbContext? dbContext, CancellationToken cancellationToken)
    {
        if (dbContext is null)
        {
            return;
        }

        var entitiesWithDomainEvents = dbContext.ChangeTracker.Entries<IHasDomainEvents>()
            .Where(e => e.Entity.DomainEvents.Any())
            .Select(e => e.Entity)
            .ToList();

        var domainEvents = entitiesWithDomainEvents.SelectMany(e => e.DomainEvents).ToList();
        
        entitiesWithDomainEvents.ForEach(e => e.ClearDomainEvents());

        foreach (var domainEvent in domainEvents)
        {
            await _publisher.Publish(domainEvent, cancellationToken);
        }
    }
}