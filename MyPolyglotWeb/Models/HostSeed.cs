using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyPolyglotCore;
using MyPolyglotWeb.Constants;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Repositories.IRepositories;
using System.Collections.Generic;

namespace MyPolyglotWeb.Models
{
    public static class HostSeed
    {

        public static IHost Seed(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                var exerciseRepository = serviceProvider.GetService<IExerciseRepository>();
                var lessonRepository = serviceProvider.GetService<ILessonRepository>();
                CreateLessons(lessonRepository);
                AddExercisesToLesson1(exerciseRepository, lessonRepository.Get(1));
                AddExercisesToLesson2(exerciseRepository, lessonRepository.Get(2));
            }
            return host;
        }

        private static void AddExercisesToLesson2(IExerciseRepository exerciseRepository, LessonDB lessonDB)
        {
            var dbExercises = new List<ExerciseDB>()
            {
                new ExerciseDB()
                {
                    RusPhrase = "Мы не оставили его.",
                    EngPhrase = "We didn't leave him.",
                    Lesson = lessonDB
                },
                new ExerciseDB()
                {
                    RusPhrase = "Он поймёт тебя.",
                    EngPhrase = "He will understand you.",
                    Lesson = lessonDB
                },
                new ExerciseDB()
                {
                    RusPhrase = "Ты открываешь ей.",
                    EngPhrase = "You open her.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "open",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = false,
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Я сломаю?",
                    EngPhrase = "Will i break?",
                    Lesson = lessonDB
                },
                new ExerciseDB()
                {
                    RusPhrase = "Я показал им?",
                    EngPhrase = "Did i show them?",
                    Lesson = lessonDB
                },
            };

            foreach (var dbExercise in dbExercises)
            {
                if (!exerciseRepository.IsExist(dbExercise.EngPhrase))
                {
                    exerciseRepository.Save(dbExercise);
                }
            }
        }

        private static void AddExercisesToLesson1(IExerciseRepository exerciseRepository, LessonDB lessonDB)
        {
            var dbExercises = new List<ExerciseDB>()
            {
                new ExerciseDB()
                {
                    RusPhrase = "Ты не увидишь.",
                    EngPhrase = "You will not see.",
                    Lesson = lessonDB
                },
                new ExerciseDB()
                {
                    RusPhrase = "Мы покажем?",
                    EngPhrase = "Will we show?",
                    Lesson = lessonDB
                },
                new ExerciseDB()
                {
                    RusPhrase = "Она работала.",
                    EngPhrase = "She worked.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "work",
                            StressOnTheFinalSyllableInRegularVerb = true,
                            Type = UnrecognizableTypes.RegularVerb,
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Ты не думал.",
                    EngPhrase = "You didn't think.",
                    Lesson = lessonDB,
                },
                new ExerciseDB()
                {
                    RusPhrase = "Я посмотрю?",
                    EngPhrase = "Will i look?",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "look",
                            StressOnTheFinalSyllableInRegularVerb = true,
                            Type = UnrecognizableTypes.RegularVerb
                        }
                    }
                }
            };

            foreach (var dbExercise in dbExercises)
            {
                if (!exerciseRepository.IsExist(dbExercise.EngPhrase))
                {
                    exerciseRepository.Save(dbExercise);
                }
            }
        }

        private static void CreateLessons(ILessonRepository lessonRepository)
        {
            foreach (var lessonName in CustomConst.LessonsNames)
            {
                if (!lessonRepository.IsExist(lessonName))
                {
                    lessonRepository.Save(new LessonDB() { LessonName = lessonName });
                }
            }
        }
    }
}
