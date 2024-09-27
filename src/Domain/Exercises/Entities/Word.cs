using Domain.Common.Models;
using Domain.Exercises.ValueObjects;

namespace Domain.Exercises.Entities;

public sealed class Word : Entity<WordId>
{
    public WordNumber Number { get; }
    public WordType Type { get; }

    private Word(WordId id, WordNumber number, WordType type) : base(id)
    {
        Number = number;
        Type = type;
    }

    public static Word Create(WordNumber number, WordType type)
    {
        return new Word(WordId.CreateUnique(), number, type);
    }
}