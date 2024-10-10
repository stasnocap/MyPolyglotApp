using Domain.Practice.Lessons;
using Domain.Practice.Lessons.ValueObjects;

namespace Infrastructure.Persistence.Seed.Practice;

public static class LessonSeed
{
    public static readonly LessonId LessonId1 = LessonId.Create(Guid.Parse("099df6d4-f116-4b6e-8cae-96dd9f3623dd"));
    public static readonly LessonId LessonId2 = LessonId.Create(Guid.Parse("8eca71ba-7524-4b77-8dc3-5c3e2b051613"));
    public static readonly LessonId LessonId3 = LessonId.Create(Guid.Parse("19e63968-9aa1-4196-af9b-020bd589103c"));
    public static readonly LessonId LessonId4 = LessonId.Create(Guid.Parse("ef710306-a1b1-4823-93eb-64d8357ed6ea"));
    public static readonly LessonId LessonId5 = LessonId.Create(Guid.Parse("c61b363f-290f-4ff4-8cd3-1845414c680f"));
    public static readonly LessonId LessonId6 = LessonId.Create(Guid.Parse("1d883b60-88a9-4186-a003-9939210b3fe2"));
    public static readonly LessonId LessonId7 = LessonId.Create(Guid.Parse("d9dadc04-9197-4b7a-aca6-c9ce18c1fef5"));
    public static readonly LessonId LessonId8 = LessonId.Create(Guid.Parse("18da835a-791c-4dd7-915f-09abf79219d1"));
    public static readonly LessonId LessonId9 = LessonId.Create(Guid.Parse("946446db-a1da-422e-bad6-ab7972987ae4"));
    public static readonly LessonId LessonId10 = LessonId.Create(Guid.Parse("49723cf9-e420-4608-a368-f2ffbd006242"));
    public static readonly LessonId LessonId11 = LessonId.Create(Guid.Parse("35c865ea-0c11-4a46-a5f0-d8c168f88907"));
    public static readonly LessonId LessonId12 = LessonId.Create(Guid.Parse("255d72a1-b6e7-4fbb-bc5a-362f2b0c4efe"));
    public static readonly LessonId LessonId13 = LessonId.Create(Guid.Parse("a26e89e2-cafd-4126-bc63-5ba53645ed6d"));
    public static readonly LessonId LessonId14 = LessonId.Create(Guid.Parse("302c1e93-e339-4850-9bc9-47dd5e37decb"));
    public static readonly LessonId LessonId15 = LessonId.Create(Guid.Parse("06e34fe3-489b-4fce-ba46-f9e30c63146f"));
    public static readonly LessonId LessonId16 = LessonId.Create(Guid.Parse("168e4970-41f5-441b-aedb-092556b63775"));
    public static readonly LessonId LessonId17 = LessonId.Create(Guid.Parse("7407b5e3-bcc3-4853-ba1c-740985bf7d52"));
    public static readonly LessonId LessonId18 = LessonId.Create(Guid.Parse("65f77c8e-3d17-419e-9529-4326811c732c"));
    public static readonly LessonId LessonId19 = LessonId.Create(Guid.Parse("a6c000b2-2aa9-4372-8788-aa7b7045b0c2"));
    public static readonly LessonId LessonId20 = LessonId.Create(Guid.Parse("21b08001-36e3-4770-affa-e4a7e87e4c7e"));
    public static readonly LessonId LessonId21 = LessonId.Create(Guid.Parse("441161d5-3f41-4e50-9655-a62c971b06b6"));
    public static readonly LessonId LessonId22 = LessonId.Create(Guid.Parse("974db683-7a40-4a0a-84a4-afc012855961"));
    public static readonly LessonId LessonId23 = LessonId.Create(Guid.Parse("d7b96b18-f735-43cd-bd5f-0aa0cfeab504"));
    public static readonly LessonId LessonId24 = LessonId.Create(Guid.Parse("85f6a657-c644-4ef9-9454-37202576c089"));
    public static readonly LessonId LessonId25 = LessonId.Create(Guid.Parse("a184277b-edcc-4af1-9c17-a2b11140be2f"));
    public static readonly LessonId LessonId26 = LessonId.Create(Guid.Parse("614a255e-2239-42ef-95e6-101f95c28499"));
    public static readonly LessonId LessonId27 = LessonId.Create(Guid.Parse("60b8431c-0450-4143-9baf-ca627495d7f5"));
    public static readonly LessonId LessonId28 = LessonId.Create(Guid.Parse("28d10443-9ac8-43e7-b176-2e40cb1565df"));
    public static readonly LessonId LessonId29 = LessonId.Create(Guid.Parse("7db36b76-017d-484b-b367-d82cea8b5036"));
    public static readonly LessonId LessonId30 = LessonId.Create(Guid.Parse("95079976-cc2e-4d0b-a4c3-42c772ce35b9"));
    public static readonly LessonId LessonId31 = LessonId.Create(Guid.Parse("8fdffe09-48a4-4b02-91ed-f808c121f45e"));

    public static IReadOnlyList<Lesson> GetLessons()
    {
        return
        [
            Lesson.Create(LessonId1, LessonNumber.Create(1).Value, LessonName.Create("Базовая форма глагола").Value).Value,
            Lesson.Create(LessonId2, LessonNumber.Create(2).Value, LessonName.Create("Местоимения. Вопросительные слова").Value).Value,
            Lesson.Create(LessonId3, LessonNumber.Create(3).Value, LessonName.Create("Глагол to be. Предлоги места. Like/Want").Value).Value,
            Lesson.Create(LessonId4, LessonNumber.Create(4).Value, LessonName.Create("Притяжательные местоимения").Value).Value,
            Lesson.Create(LessonId5, LessonNumber.Create(5).Value, LessonName.Create("Профессии. Этикет").Value).Value,
            Lesson.Create(LessonId6, LessonNumber.Create(6).Value, LessonName.Create("Степени сравнения прилагательных. Указательные местоимения").Value).Value,
            Lesson.Create(LessonId7, LessonNumber.Create(7).Value, LessonName.Create("Слова-параметры. Употребление muck и many, little и few").Value).Value,
            Lesson.Create(LessonId8, LessonNumber.Create(8).Value, LessonName.Create("Предлоги и параметры времени").Value).Value,
            Lesson.Create(LessonId9, LessonNumber.Create(9).Value, LessonName.Create("There is / There are").Value).Value,
            Lesson.Create(LessonId10, LessonNumber.Create(10).Value, LessonName.Create("Предлоги направления и движения").Value).Value,
            Lesson.Create(LessonId11, LessonNumber.Create(11).Value, LessonName.Create("Модальные глаголы can, must, should").Value).Value,
            Lesson.Create(LessonId12, LessonNumber.Create(12).Value, LessonName.Create("Continuous").Value).Value,
            Lesson.Create(LessonId13, LessonNumber.Create(13).Value, LessonName.Create("Описание людей. Погода").Value).Value,
            Lesson.Create(LessonId14, LessonNumber.Create(14).Value, LessonName.Create("Повелительное наклонение").Value).Value,
            Lesson.Create(LessonId15, LessonNumber.Create(15).Value, LessonName.Create("Фразовые глаголы").Value).Value,
            Lesson.Create(LessonId16, LessonNumber.Create(16).Value, LessonName.Create("Present Perfect").Value).Value,
            Lesson.Create(LessonId17, LessonNumber.Create(17).Value, LessonName.Create("Past Perfect").Value).Value,
            Lesson.Create(LessonId18, LessonNumber.Create(18).Value, LessonName.Create("Future Perfect").Value).Value,
            Lesson.Create(LessonId19, LessonNumber.Create(19).Value, LessonName.Create("Perfect Tenses").Value).Value,
            Lesson.Create(LessonId20, LessonNumber.Create(20).Value, LessonName.Create("Present Perfect Continuous").Value).Value,
            Lesson.Create(LessonId21, LessonNumber.Create(21).Value, LessonName.Create("Past Perfect Continuous").Value).Value,
            Lesson.Create(LessonId22, LessonNumber.Create(22).Value, LessonName.Create("Future Perfect Continuous").Value).Value,
            Lesson.Create(LessonId23, LessonNumber.Create(23).Value, LessonName.Create("Perfect Continuous Tenses").Value).Value,
            Lesson.Create(LessonId24, LessonNumber.Create(24).Value, LessonName.Create("Present Participle Simple").Value).Value,
            Lesson.Create(LessonId25, LessonNumber.Create(25).Value, LessonName.Create("Past Participle").Value).Value,
            Lesson.Create(LessonId26, LessonNumber.Create(26).Value, LessonName.Create("Present Participle Perfect").Value).Value,
            Lesson.Create(LessonId27, LessonNumber.Create(27).Value, LessonName.Create("The Participle").Value).Value,
            Lesson.Create(LessonId28, LessonNumber.Create(28).Value, LessonName.Create("Simple Passive").Value).Value,
            Lesson.Create(LessonId29, LessonNumber.Create(29).Value, LessonName.Create("Continuous Passive").Value).Value,
            Lesson.Create(LessonId30, LessonNumber.Create(30).Value, LessonName.Create("Perfect Passive").Value).Value,
            Lesson.Create(LessonId31, LessonNumber.Create(31).Value, LessonName.Create("Passive Voice").Value).Value,
        ];
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