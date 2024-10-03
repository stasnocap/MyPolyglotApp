using Domain.Practice.Exercises;
using Domain.Practice.Exercises.Entities;
using Domain.Practice.Exercises.ValueObjects;

namespace Infrastructure.Persistence.Seed;

public static class ExerciseSeed
{
    public static readonly Guid GuidForExerciseId1 = Guid.Parse("6ed88863-0c5d-45cd-b361-3071bf62a907");
    public static readonly ExerciseId ExerciseId1 = ExerciseId.Create(GuidForExerciseId1);
    
    public static readonly Guid GuidForExerciseId2 = Guid.Parse("ec6ea7e1-3dbb-45a7-801c-3441c6ef962f");
    public static readonly ExerciseId ExerciseId2 = ExerciseId.Create(GuidForExerciseId2);
    
    public static readonly Guid GuidForExerciseId3 = Guid.Parse("dacb0b73-7bb2-491f-9bf6-adb1f3e2f50f");
    public static readonly ExerciseId ExerciseId3 = ExerciseId.Create(GuidForExerciseId3);
    
    public static readonly Guid GuidForExerciseId4 = Guid.Parse("f8d8fcb2-4df3-4321-9538-fe576ef04c2d");
    public static readonly ExerciseId ExerciseId4 = ExerciseId.Create(GuidForExerciseId4);
    
    public static readonly Guid GuidForExerciseId5 = Guid.Parse("69dfc0ba-ac95-44bb-b412-b36b2a45f6bb");
    public static readonly ExerciseId ExerciseId5 = ExerciseId.Create(GuidForExerciseId5);

    public static IReadOnlyList<object> GetSeedExercisesForLesson1()
    {
        var lessonId = LessonSeed.LessonId1;
        return
        [
            Exercise.Create(ExerciseId1, lessonId, EngPhrase.Create("Ты не увидишь.").Value, RusPhrase.Create("You will not see.").Value).Value,
            Exercise.Create(ExerciseId2, lessonId, EngPhrase.Create("Will we show?").Value, RusPhrase.Create("Мы покажем?").Value).Value,
            Exercise.Create(ExerciseId3, lessonId, EngPhrase.Create("She worked.").Value, RusPhrase.Create("Она работала.").Value).Value,
            Exercise.Create(ExerciseId4, lessonId, EngPhrase.Create("You didn't think.").Value, RusPhrase.Create("Ты не думал.").Value).Value,
            Exercise.Create(ExerciseId5, lessonId, EngPhrase.Create("Will i look?").Value, RusPhrase.Create("Я посмотрю?").Value).Value,
        ];
    }

    public static IReadOnlyList<object> GetSeedWordsForLesson1()
    {
        return
        [
            Word.Create(ExerciseId1, WordNumber.Create(1).Value, WordType.Pronoun),
            Word.Create(ExerciseId1, WordNumber.Create(2).Value, WordType.ModalVerb),
            Word.Create(ExerciseId1, WordNumber.Create(3).Value, WordType.Verb),
            
            Word.Create(ExerciseId2, WordNumber.Create(1).Value, WordType.ModalVerb),
            Word.Create(ExerciseId2, WordNumber.Create(2).Value, WordType.Pronoun),
            Word.Create(ExerciseId2, WordNumber.Create(3).Value, WordType.Verb),

            Word.Create(ExerciseId3, WordNumber.Create(1).Value, WordType.Pronoun),
            Word.Create(ExerciseId3, WordNumber.Create(2).Value, WordType.Verb),

            Word.Create(ExerciseId4, WordNumber.Create(1).Value, WordType.Pronoun),
            Word.Create(ExerciseId4, WordNumber.Create(2).Value, WordType.PrimaryVerb),
            Word.Create(ExerciseId4, WordNumber.Create(3).Value, WordType.Verb),
            
            Word.Create(ExerciseId5, WordNumber.Create(1).Value, WordType.ModalVerb),
            Word.Create(ExerciseId5, WordNumber.Create(2).Value, WordType.Pronoun),
            Word.Create(ExerciseId5, WordNumber.Create(3).Value, WordType.Verb),
        ];
    }
}