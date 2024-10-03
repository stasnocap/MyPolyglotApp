﻿using Domain.Common.Models;
using Domain.Practice.Exercises.Entities;
using Domain.Practice.Exercises.ValueObjects;
using Domain.Practice.Lessons.ValueObjects;
using ErrorOr;

namespace Domain.Practice.Exercises;

public sealed class Exercise : AggregateRoot<ExerciseId>
{
    private readonly List<Word> _words = [];
    
    public LessonId LessonId { get; }
    public RusPhrase RusPhrase { get; }
    public IReadOnlyList<Word> Words => _words.AsReadOnly();
    
    private Exercise(ExerciseId id, LessonId lessonId, RusPhrase rusPhrase) : base(id)
    {
        LessonId = lessonId;
        RusPhrase = rusPhrase;
    }
    
    // ReSharper disable once UnusedMember.Local
    private Exercise()
    {
    }

    public static ErrorOr<Exercise> Create(LessonId lessonId, RusPhrase rusPhrase)
    {
        return new Exercise(ExerciseId.CreateUnique(), lessonId, rusPhrase);
    }

    public static ErrorOr<Exercise> Create(ExerciseId exerciseId, LessonId lessonId, RusPhrase rusPhrase)
    {
        return new Exercise(exerciseId, lessonId, rusPhrase);
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