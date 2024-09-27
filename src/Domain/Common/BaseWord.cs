using Domain.Common.Models;
using Domain.Common.ValueObjects;

namespace Domain.Common;

public abstract class BaseWord<TId> : AggregateRoot<TId> where TId : notnull
{
    public Text Text { get; }

    protected BaseWord(TId id, Text text) : base(id)
    {
        Text = text;
    }
}