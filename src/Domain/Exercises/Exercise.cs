using Domain.Common.Models;
using Domain.Exercises.Entities;
using Domain.Exercises.ValueObjects;
using Domain.Lessons.ValueObjects;
using ErrorOr;

namespace Domain.Exercises;

public sealed class Exercise : AggregateRoot<ExerciseId>
{
    private readonly List<Word> _words = [];
    
    public LessonId LessonId { get; }
    public EngPhrase EngPhrase { get; }
    public RusPhrase RusPhrase { get; }
    public IReadOnlyList<Word> Words => _words.AsReadOnly();
    
    private Exercise(ExerciseId id, LessonId lessonId, EngPhrase engPhrase, RusPhrase rusPhrase) : base(id)
    {
        LessonId = lessonId;
        EngPhrase = engPhrase;
        RusPhrase = rusPhrase;
    }

    public static ErrorOr<Exercise> Create(LessonId lessonId, EngPhrase engPhrase, RusPhrase rusPhrase)
    {
        return new Exercise(ExerciseId.CreateUnique(), lessonId, engPhrase, rusPhrase);
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