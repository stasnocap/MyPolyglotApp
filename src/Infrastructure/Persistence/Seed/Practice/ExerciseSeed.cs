using Domain.Common.ValueObjects;
using Domain.Practice.Exercises;
using Domain.Practice.Exercises.Entities;
using Domain.Practice.Exercises.ValueObjects;

namespace Infrastructure.Persistence.Seed.Practice;

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

    public static IReadOnlyList<Exercise> GetSeedExercisesForLesson1()
    {
        var lessonId = LessonSeed.LessonId1;
        return
        [
            Exercise.Create(ExerciseId1, lessonId, RusPhrase.Create("Ты не увидишь.").Value).Value,
            Exercise.Create(ExerciseId2, lessonId, RusPhrase.Create("Мы покажем?").Value).Value,
            Exercise.Create(ExerciseId3, lessonId, RusPhrase.Create("Она работала.").Value).Value,
            Exercise.Create(ExerciseId4, lessonId, RusPhrase.Create("Ты не думал.").Value).Value,
            Exercise.Create(ExerciseId5, lessonId, RusPhrase.Create("Я посмотрю?").Value).Value,
        ];
    }

    public static IReadOnlyList<Word> GetSeedWordsForLesson1()
    {
        return
        [
            Word.Create(WordId.Create(Guid.Parse("03e9797f-ab16-4422-bfd9-bf76ca33f436")), ExerciseId1, WordNumber.Create(1).Value, Text.Create("You").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("c02b1a8b-0138-47d6-873b-16e084831444")), ExerciseId1, WordNumber.Create(2).Value, Text.Create("will not").Value, WordType.ModalVerb),
            Word.Create(WordId.Create(Guid.Parse("1deab725-e374-4ad7-a169-45a4e77d58f5")), ExerciseId1, WordNumber.Create(3).Value, Text.Create("see.").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("16738012-8d9a-4790-810e-bbf91672cdf6")), ExerciseId2, WordNumber.Create(1).Value, Text.Create("Will").Value, WordType.ModalVerb),
            Word.Create(WordId.Create(Guid.Parse("a5915abb-95f9-425d-a054-5ee27997b634")), ExerciseId2, WordNumber.Create(2).Value, Text.Create("we").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("4da38ea9-9eb1-4463-928b-5d38bea9c17b")), ExerciseId2, WordNumber.Create(3).Value, Text.Create("show?").Value, WordType.Verb),

            Word.Create(WordId.Create(Guid.Parse("d74bcb9b-36d6-4ec0-8cf8-b1a8be9624af")), ExerciseId3, WordNumber.Create(1).Value, Text.Create("She").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("9215550e-7cfd-4e41-a946-90e09def9e39")), ExerciseId3, WordNumber.Create(2).Value, Text.Create("worked?").Value, WordType.Verb),
            
            Word.Create(WordId.Create(Guid.Parse("862f83cd-d378-410e-88d6-27b01a06a2dc")), ExerciseId4, WordNumber.Create(1).Value, Text.Create("You").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("e86dff93-aeb8-476b-bfe0-ded0dc21e2de")), ExerciseId4, WordNumber.Create(2).Value, Text.Create("didn't").Value, WordType.PrimaryVerb),
            Word.Create(WordId.Create(Guid.Parse("ee70e409-d59e-4c23-86eb-1f2878181e1b")), ExerciseId4, WordNumber.Create(3).Value, Text.Create("think.").Value, WordType.Verb),
            
            Word.Create(WordId.Create(Guid.Parse("ccac4b45-c615-438b-aeb4-2ec52947e9c4")), ExerciseId5, WordNumber.Create(1).Value, Text.Create("Will").Value, WordType.ModalVerb),
            Word.Create(WordId.Create(Guid.Parse("dfd01a72-3ec6-47b1-8a40-32c3a32ad2da")), ExerciseId5, WordNumber.Create(2).Value, Text.Create("I").Value, WordType.Pronoun),
            Word.Create(WordId.Create(Guid.Parse("37b924c3-3886-49a1-8c0a-07a718957e92")), ExerciseId5, WordNumber.Create(3).Value, Text.Create("look?").Value, WordType.Verb),
        ];
    }
}