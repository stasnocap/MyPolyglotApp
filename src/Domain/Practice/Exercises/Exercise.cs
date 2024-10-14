using Domain.Common.Models;
using Domain.Practice.Exercises.Entities;
using Domain.Practice.Exercises.ValueObjects;
using Domain.Practice.Lessons.ValueObjects;
using ErrorOr;

namespace Domain.Practice.Exercises;

public sealed class Exercise : AggregateRoot<ExerciseId>
{
    private readonly List<Word> _words = [];
    private readonly List<LessonId> _lessonIds = [];
    
    public RusPhrase RusPhrase { get; }
    public IReadOnlyList<Word> Words => _words.AsReadOnly();
    public IReadOnlyList<LessonId> LessonIds => _lessonIds.AsReadOnly();
    
    private Exercise(ExerciseId id, RusPhrase rusPhrase) : base(id)
    {
        RusPhrase = rusPhrase;
    }
    
    // ReSharper disable once UnusedMember.Local
    private Exercise()
    {
    }

    public static ErrorOr<Exercise> Create(RusPhrase rusPhrase)
    {
        return new Exercise(ExerciseId.CreateUnique(), rusPhrase);
    }

    public static ErrorOr<Exercise> Create(ExerciseId exerciseId, RusPhrase rusPhrase)
    {
        return new Exercise(exerciseId, rusPhrase);
    }

    public void AddWord(Word word)
    {
        _words.Add(word);
    }

    public void AddWords(IReadOnlyList<Word> words)
    {
        _words.AddRange(words);
    }
}