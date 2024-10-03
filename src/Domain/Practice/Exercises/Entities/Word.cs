using Domain.Common.Models;
using Domain.Practice.Exercises.ValueObjects;

namespace Domain.Practice.Exercises.Entities;

public sealed class Word : Entity<WordId>
{
    public ExerciseId ExerciseId { get; }
    public WordNumber Number { get; }
    public WordType Type { get; }

    private Word(WordId id, ExerciseId exerciseId, WordNumber number, WordType type) : base(id)
    {
        Number = number;
        Type = type;
        ExerciseId = exerciseId;
    }

    public static Word Create(ExerciseId exerciseId, WordNumber number, WordType type)
    {
        return new Word(WordId.CreateUnique(), exerciseId, number, type);
    }
}