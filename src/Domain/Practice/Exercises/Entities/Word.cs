using Domain.Common;
using Domain.Common.ValueObjects;
using Domain.Practice.Exercises.ValueObjects;

namespace Domain.Practice.Exercises.Entities;

public sealed class Word : BaseWord<WordId>
{
    public ExerciseId ExerciseId { get; }
    public WordNumber Number { get; }
    public WordType Type { get; }

    private Word(WordId id, ExerciseId exerciseId, WordNumber number, Text text, WordType type) : base(id, text)
    {
        Number = number;
        Type = type;
        ExerciseId = exerciseId;
    }

    public static Word Create(ExerciseId exerciseId, WordNumber number, Text text, WordType type)
    {
        return new Word(WordId.CreateUnique(), exerciseId, number, text, type);
    }

    public static Word Create(WordId wordId, ExerciseId exerciseId, WordNumber number, Text text, WordType type)
    {
        return new Word(wordId, exerciseId, number, text, type);
    }
}