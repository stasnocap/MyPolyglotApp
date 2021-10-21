using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyPolyglotCore;
using MyPolyglotCore.Words;
using MyPolyglotWeb.Constants;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Repositories.IRepositories;
using System;
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
            }
            return host;
        }

        private static void AddExercisesToLesson1(IExerciseRepository exerciseRepository, LessonDB lesson)
        {
            var dbExercises = new List<ExerciseDB>()
            {
                new ExerciseDB()
                {
                    RusPhrase = "Ты не увидишь.",
                    EngPhrase = "You will not see.",
                    Lesson = lesson
                },
                new ExerciseDB()
                {
                    RusPhrase = "Мы покажем?",
                    EngPhrase = "Will we show?",
                    Lesson = lesson
                },
                new ExerciseDB()
                {
                    RusPhrase = "Она работала.",
                    EngPhrase = "She worked.",
                    Lesson = lesson,
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
                    Lesson = lesson,
                },
                new ExerciseDB()
                {
                    RusPhrase = "Я посмотрю?",
                    EngPhrase = "Will i look?",
                    Lesson = lesson,
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

            foreach (var exercise in dbExercises)
            {
                if (!exerciseRepository.IsExist(exercise.EngPhrase))
                {
                    exerciseRepository.Save(exercise);
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
