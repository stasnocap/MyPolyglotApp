using Domain.Practice.Lessons;
using Domain.Practice.Lessons.ValueObjects;

namespace Infrastructure.Persistence.Seed.Practice;

public static class LessonSeed
{
    public static readonly LessonId LessonId1 = LessonId.Create(Guid.Parse("099df6d4-f116-4b6e-8cae-96dd9f3623dd"));

    public static Lesson GetLesson1()
    {
        var lesson1 = Lesson.Create(LessonId1, LessonNumber.Create(1).Value, LessonName.Create("Базовая форма глагола").Value).Value;

        return lesson1;
    }

    public static IReadOnlyList<object> GetExerciseIdsForLesson1()
    {
        return
        [
            new
            {
                Id = 1,
                Value = ExerciseSeed.GuidForExerciseId1,
                LessonId = LessonId1,
            },
            new
            {
                Id = 2,
                Value = ExerciseSeed.GuidForExerciseId2,
                LessonId = LessonId1,
            },
            new
            {
                Id = 3,
                Value = ExerciseSeed.GuidForExerciseId3,
                LessonId = LessonId1,
            },
            new
            {
                Id = 4,
                Value = ExerciseSeed.GuidForExerciseId4,
                LessonId = LessonId1,
            },
            new
            {
                Id = 5,
                Value = ExerciseSeed.GuidForExerciseId5,
                LessonId = LessonId1,
            },
        ];
    }
}