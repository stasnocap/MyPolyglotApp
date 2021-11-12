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
                AddExercisesToLesson3(exerciseRepository, lessonRepository.Get(3));
                AddExercisesToLesson4(exerciseRepository, lessonRepository.Get(4));
                AddExercisesToLesson5(exerciseRepository, lessonRepository.Get(5));
                AddExercisesToLesson6(exerciseRepository, lessonRepository.Get(6));
                AddExercisesToLesson7(exerciseRepository, lessonRepository.Get(7));
                AddExercisesToLesson8(exerciseRepository, lessonRepository.Get(8));
                AddExercisesToLesson9(exerciseRepository, lessonRepository.Get(9));
                AddExercisesToLesson10(exerciseRepository, lessonRepository.Get(10));
                AddExercisesToLesson11(exerciseRepository, lessonRepository.Get(11));
                AddExercisesToLesson12(exerciseRepository, lessonRepository.Get(12));
                AddExercisesToLesson13(exerciseRepository, lessonRepository.Get(13));
                AddExercisesToLesson14(exerciseRepository, lessonRepository.Get(14));
                AddExercisesToLesson15(exerciseRepository, lessonRepository.Get(15));
                AddExercisesToLesson16(exerciseRepository, lessonRepository.Get(16));
                AddExercisesToLesson17(exerciseRepository, lessonRepository.Get(17));
                AddExercisesToLesson18(exerciseRepository, lessonRepository.Get(18));
                AddExercisesToLesson19(exerciseRepository, lessonRepository.Get(19));
                AddExercisesToLesson20(exerciseRepository, lessonRepository.Get(20));
            }
            return host;
        }

        private static void AddExercisesToLesson20(IExerciseRepository exerciseRepository, LessonDB lessonDB)
        {
            var dbExercises = new List<ExerciseDB>()
            {
                new ExerciseDB()
                {
                    RusPhrase = "Она готовит ужин уже три часа.",
                    EngPhrase = "She has been cooking dinner for three hours.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "cook",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "dinner",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Я пекла этот пирог с самого утра.",
                    EngPhrase = "I have been baking this cake since morning.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "bake",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "cake",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Рабочие пытаются сдвинуть наш шкаф с места вот уже полчаса.",
                    EngPhrase = "The workers have been trying to move our cupboard for half an hour.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "workers",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = true
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "try",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "move",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "cupboard",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "half",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Я читаю этот журнал с тех пор, как купил его неделю назад.",
                    EngPhrase = "I have been reading this magazine since I bought it a week ago.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "magazine",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Я жду свою маму уже давно.",
                    EngPhrase = "I have been waiting for my mother for a long time.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "wait",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true
                        },
                    }
                },
            };

            SaveExercises(exerciseRepository, dbExercises);
        }

        private static void AddExercisesToLesson19(IExerciseRepository exerciseRepository, LessonDB lessonDB)
        {
            var dbExercises = new List<ExerciseDB>()
            {
                new ExerciseDB()
                {
                    RusPhrase = "Они сдадут все свои экзамены до того, как поедут в лагерь.",
                    EngPhrase = "They will have passed all their exams before they go to the camp.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "pass",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "exams",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = true
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "all",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "camp",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Мы уже написали статью к пяти часам?",
                    EngPhrase = "Had we written the article by five o'clock?",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "article",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "o'clock",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Она написала только 2 письма к полудню.",
                    EngPhrase = "She had written only two letters by noon.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "letters",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = true
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Вы вернулись домой до того, как начался дождь.",
                    EngPhrase = "You had returned home before the rain began.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "return",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "rain",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Она уже пришла домой к 9 часам.",
                    EngPhrase = "She had already come home by nine o'clock.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "o'clock",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    }
                },
            };

            SaveExercises(exerciseRepository, dbExercises);
        }

        private static void AddExercisesToLesson18(IExerciseRepository exerciseRepository, LessonDB lessonDB)
        {
            var dbExercises = new List<ExerciseDB>()
            {
                new ExerciseDB()
                {
                    RusPhrase = "Ученики займут свои места до того, как начнется урок.",
                    EngPhrase = "The pupils will have taken their seats before the lesson starts.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "pupils",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = true
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "seats",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = true
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "lesson",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "start",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Они не успеют выиграть три игры к концу месяца.",
                    EngPhrase = "They will not have won three games by the end of the month.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "games",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = true
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Я уже окончу эту работу до того, как вы возвратитесь.",
                    EngPhrase = "I will have finished this work, before you return.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "finish",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "work",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "return",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Они еще не отгрузят товар, когда придет ваша телеграмма.",
                    EngPhrase = "They will not have shipped the goods when your telegram arrives.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "ship",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "goods",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = true
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "telegram",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "arrive",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Я не закончу писать доклад к вечеру.",
                    EngPhrase = "I will not have finished the report by tonight.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "finish",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "report",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    }
                },
            };

            SaveExercises(exerciseRepository, dbExercises);
        }

        private static void AddExercisesToLesson17(IExerciseRepository exerciseRepository, LessonDB lessonDB)
        {
            var dbExercises = new List<ExerciseDB>()
            {
                new ExerciseDB()
                {
                    RusPhrase = "Я не успел закончить проект к началу той недели.",
                    EngPhrase = "I had not finished the project by the beginning of that week.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "finish",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "project",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Он сделал домашнее задание до того, как его родители вернулись домой?",
                    EngPhrase = "Had he done his homework before his parents returned home?",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "homework",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "return",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "home",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Он уже написал письмо, когда ты вошел?",
                    EngPhrase = "Had he written a letter, when you came in?",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "letter",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Вы вернулись домой до того, как начался дождь.",
                    EngPhrase = "You had returned home before the rain began.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "return",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "home",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "rain",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Когда мы приехали на станцию, поезд уже ушел.",
                    EngPhrase = "When we came to the station the train had already gone.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "station",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "train",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    }
                },
            };

            SaveExercises(exerciseRepository, dbExercises);
        }

        private static void AddExercisesToLesson16(IExerciseRepository exerciseRepository, LessonDB lessonDB)
        {
            var dbExercises = new List<ExerciseDB>()
            {
                new ExerciseDB()
                {
                    RusPhrase = "Он только что вышел.",
                    EngPhrase = "He has just gone out.",
                    Lesson = lessonDB,
                },
                new ExerciseDB()
                {
                    RusPhrase = "Думаю, что я видел вас где-то.",
                    EngPhrase = "I think I have seen you somewhere.",
                    Lesson = lessonDB,
                },
                new ExerciseDB()
                {
                    RusPhrase = "Я выполнил работу.",
                    EngPhrase = "I have done the work.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "work",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Я уже написал письмо своему другу.",
                    EngPhrase = "I have already written the letter to my friend.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "letter",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Он только что посетил этот супермаркет.",
                    EngPhrase = "He has just visited this supermarket.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "visit",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "supermarket",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    }
                },
            };

            SaveExercises(exerciseRepository, dbExercises);
        }

        private static void AddExercisesToLesson15(IExerciseRepository exerciseRepository, LessonDB lessonDB)
        {
            var dbExercises = new List<ExerciseDB>()
            {
                new ExerciseDB()
                {
                    RusPhrase = "Он сбросил вес.",
                    EngPhrase = "He took off weight.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "weight",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Твой сын просит выключить свет.",
                    EngPhrase = "Your son asks to turn on the light.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "son",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "ask",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "turn",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "light",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Он свалился с пневмонией.",
                    EngPhrase = "He went down with pneumonia.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "pneumonia",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Он взломал дверь.",
                    EngPhrase = "He broke down the door.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "door",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Цены никогда не падают.",
                    EngPhrase = "The prices never go down.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "prices",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = true
                        }
                    }
                },
            };

            SaveExercises(exerciseRepository, dbExercises);
        }

        private static void AddExercisesToLesson14(IExerciseRepository exerciseRepository, LessonDB lessonDB)
        {
            var dbExercises = new List<ExerciseDB>()
            {
                new ExerciseDB()
                {
                    RusPhrase = "Беги к ней.",
                    EngPhrase = "Run to her.",
                    Lesson = lessonDB,
                },
                new ExerciseDB()
                {
                    RusPhrase = "Не поворачивай его тумбочку.",
                    EngPhrase = "Don't turn his nightstand.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "nightstand",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Не бери мой планшет.",
                    EngPhrase = "Don't take my tablet.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "tablet",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Помни про нас.",
                    EngPhrase = "Remember about us.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "remember",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = false
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Пусть он ответит.",
                    EngPhrase = "Let him answer.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "answer",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = false
                        }
                    }
                },
            };

            SaveExercises(exerciseRepository, dbExercises);
        }

        private static void AddExercisesToLesson13(IExerciseRepository exerciseRepository, LessonDB lessonDB)
        {
            var dbExercises = new List<ExerciseDB>()
            {
                new ExerciseDB()
                {
                    RusPhrase = "Мне холодно?",
                    EngPhrase = "Am I cold?",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "cold",
                            Type = UnrecognizableTypes.Adjective,
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "У меня не голубые глаза.",
                    EngPhrase = "I do not have blue eyes.",
                    Lesson = lessonDB,
                },
                new ExerciseDB()
                {
                    RusPhrase = "Ты здоров.",
                    EngPhrase = "You are healthy.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "healthy",
                            Type = UnrecognizableTypes.Adjective
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Вчера было жарко.",
                    EngPhrase = "It was hot yesterday.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "hot",
                            Type = UnrecognizableTypes.Adjective
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Она взрослая.",
                    EngPhrase = "She is adult.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "adult",
                            Type = UnrecognizableTypes.Adjective
                        }
                    }
                },
            };

            SaveExercises(exerciseRepository, dbExercises);
        }

        private static void AddExercisesToLesson12(IExerciseRepository exerciseRepository, LessonDB lessonDB)
        {
            var dbExercises = new List<ExerciseDB>()
            {
                new ExerciseDB()
                {
                    RusPhrase = "Он читал письмо с 4 до 10 вчера.",
                    EngPhrase = "He was reading the letter from four to ten yesterday.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "letter",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false,
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Мы отвечали на письмо в 4 вчера.",
                    EngPhrase = "We were answering the letter at four yesterday.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "answer",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "letter",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false,
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Ты чувствуешь себя плохо целый день сегодня.",
                    EngPhrase = "You are feeling bad the whole day today.",
                    Lesson = lessonDB,
                },
                new ExerciseDB()
                {
                    RusPhrase = "Мы изучали французский целый день вчера.",
                    EngPhrase = "We were studying French the whole day yesterday.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "study",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = false
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Ты будешь читать книгу целый день завтра.",
                    EngPhrase = "You will be reading the book the whole day tomorrow.",
                    Lesson = lessonDB,
                },
            };

            SaveExercises(exerciseRepository, dbExercises);
        }

        private static void AddExercisesToLesson11(IExerciseRepository exerciseRepository, LessonDB lessonDB)
        {
            var dbExercises = new List<ExerciseDB>()
            {
                new ExerciseDB()
                {
                    RusPhrase = "Мы не должны чувствовать.",
                    EngPhrase = "We mustn't feel.",
                    Lesson = lessonDB,
                },
                new ExerciseDB()
                {
                    RusPhrase = "Нужно мне стоять?",
                    EngPhrase = "Should I stand?",
                    Lesson = lessonDB,
                },
                new ExerciseDB()
                {
                    RusPhrase = "Мы можем закрыть.",
                    EngPhrase = "We can close.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "close",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Мы не показали.",
                    EngPhrase = "We didn't show.",
                    Lesson = lessonDB,
                },
                new ExerciseDB()
                {
                    RusPhrase = "Она не должна ответить.",
                    EngPhrase = "She must not answer.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "answer",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = false
                        }
                    }
                },
            };

            SaveExercises(exerciseRepository, dbExercises);
        }

        private static void AddExercisesToLesson10(IExerciseRepository exerciseRepository, LessonDB lessonDB)
        {
            var dbExercises = new List<ExerciseDB>()
            {
                new ExerciseDB()
                {
                    RusPhrase = "Он идёт на станцию?",
                    EngPhrase = "Does he go on the station?",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "station",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Ты не выйдешь из сада.",
                    EngPhrase = "You will not out of from the garden.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "garden",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "В комнате не будет шкафов.",
                    EngPhrase = "There won't be cupboards in the room.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "cupboard",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = true
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "На подоконнике будет чашка.",
                    EngPhrase = "There will be a cup on the windowsill.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "cup",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "windowsill",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Под столом были стаканы?",
                    EngPhrase = "Were there glasses under the table?",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "glasses",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = true
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "table",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    }
                },
            };

            SaveExercises(exerciseRepository, dbExercises);
        }

        private static void AddExercisesToLesson9(IExerciseRepository exerciseRepository, LessonDB lessonDB)
        {
            var dbExercises = new List<ExerciseDB>()
            {
                new ExerciseDB()
                {
                    RusPhrase = "На полу не было ручек.",
                    EngPhrase = "There were not pens on the floor.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "pens",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = true
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "floor",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Под столом есть ножи.",
                    EngPhrase = "There are knives under the table.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "knives",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = true
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "table",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Под креслом будет мяч.",
                    EngPhrase = "There will be a ball under the armchair.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "ball",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "armchair",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "На столе нет ручки.",
                    EngPhrase = "There isn't a pen on the table.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "pen",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "table",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Под креслом был стакан?",
                    EngPhrase = "Was there a glass under the armchair?",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "glass",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "armchair",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    }
                },
            };

            SaveExercises(exerciseRepository, dbExercises);
        }

        private static void AddExercisesToLesson8(IExerciseRepository exerciseRepository, LessonDB lessonDB)
        {
            var dbExercises = new List<ExerciseDB>()
            {
                new ExerciseDB()
                {
                    RusPhrase = "Она не повернула нас 6 месяцев назад.",
                    EngPhrase = "She didn't turn us six months ago.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "turn",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Он будет расти через 2 месяца?",
                    EngPhrase = "Will he grow in 2 months?",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "2 months",
                            Type = UnrecognizableTypes.NumberWithNoun
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Я расскажу тебе через 6 месяцев.",
                    EngPhrase = "I will tell you in 6 months.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "6 months",
                            Type = UnrecognizableTypes.NumberWithNoun
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Ты будешь там через 6 месяцев?",
                    EngPhrase = "Will you be there in 6 months?",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "6 months",
                            Type = UnrecognizableTypes.NumberWithNoun
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Она любила их в выходные?",
                    EngPhrase = "Did she love them at the weekend?",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "love",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true,
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Она была там вечером.",
                    EngPhrase = "She was there in the evening.",
                    Lesson = lessonDB,
                }
            };

            SaveExercises(exerciseRepository, dbExercises);
        }

        private static void AddExercisesToLesson7(IExerciseRepository exerciseRepository, LessonDB lessonDB)
        {
            var dbExercises = new List<ExerciseDB>()
            {
                new ExerciseDB()
                {
                    RusPhrase = "Мы будем читать кому-нибудь.",
                    EngPhrase = "We will read somebody.",
                    Lesson = lessonDB
                },
                new ExerciseDB()
                {
                    RusPhrase = "Они чувствуют везде?",
                    EngPhrase = "Do they feel everywhere?",
                    Lesson = lessonDB
                },
                new ExerciseDB()
                {
                    RusPhrase = "Ты встречаешь везде?",
                    EngPhrase = "Do you meet everywhere?",
                    Lesson = lessonDB
                },
                new ExerciseDB()
                {
                    RusPhrase = "Он будет знать всех?",
                    EngPhrase = "Will he know everybody?",
                    Lesson = lessonDB
                },
                new ExerciseDB()
                {
                    RusPhrase = "Он никогда не видит.",
                    EngPhrase = "He never sees.",
                    Lesson = lessonDB
                },
            };

            SaveExercises(exerciseRepository, dbExercises);
        }

        private static void AddExercisesToLesson6(IExerciseRepository exerciseRepository, LessonDB lessonDB)
        {
            var dbExercises = new List<ExerciseDB>()
            {
                new ExerciseDB()
                {
                    RusPhrase = "Эта ручка не больше той.",
                    EngPhrase = "This pen is not bigger than that one.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "pen",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false,
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "big",
                            Type = UnrecognizableTypes.RegularComparisonAdjective,
                            SyllablesInRegularComparisonAdjective = 1
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "one",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Этот телевизор не дорогой.",
                    EngPhrase = "This tv is not expensive.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "tv",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "expensive",
                            Type = UnrecognizableTypes.Adjective
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Этот телефон дешевле того?",
                    EngPhrase = "Is this phone cheaper than that one?",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "phone",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "cheap",
                            Type = UnrecognizableTypes.RegularComparisonAdjective,
                            SyllablesInRegularComparisonAdjective = 1
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "one",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Эта ручка длиннее той.",
                    EngPhrase = "This pen is longer than that one.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "pen",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "long",
                            Type = UnrecognizableTypes.RegularComparisonAdjective,
                            SyllablesInRegularComparisonAdjective = 1
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "one",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Эти апельсины самые маленькие?",
                    EngPhrase = "Are these oranges the least?",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "oranges",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = true
                        },
                    }
                },
            };

            SaveExercises(exerciseRepository, dbExercises);
        }

        private static void AddExercisesToLesson5(IExerciseRepository exerciseRepository, LessonDB lessonDB)
        {
            var dbExercises = new List<ExerciseDB>()
            {
                new ExerciseDB()
                {
                    RusPhrase = "Они учатся на гидов?",
                    EngPhrase = "Do they study to be guides?",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "study",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "guides",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = true
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Я не буду менеджером.",
                    EngPhrase = "I will not be a manager.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "manager",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Мы учились на менеджеров.",
                    EngPhrase = "We studied to be managers.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "study",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "managers",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = true
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Они работали в компании дизайнерами?",
                    EngPhrase = "Did they work in a company as designers?",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "work",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "designers",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = true
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Ты историк.",
                    EngPhrase = "You are a historian.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "historian",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        }
                    }
                },
            };

            SaveExercises(exerciseRepository, dbExercises);
        }

        private static void AddExercisesToLesson4(IExerciseRepository exerciseRepository, LessonDB lessonDB)
        {
            var dbExercises = new List<ExerciseDB>()
            {
                new ExerciseDB()
                {
                    RusPhrase = "Он будет их актёром?",
                    EngPhrase = "Will he be their actor?",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "actor",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Мы не их бухгалтеры.",
                    EngPhrase = "We are not their accountants.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "accountants",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = true
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Мы были его историками.",
                    EngPhrase = "We were his historians.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "historians",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = true
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Он будет её писателем.",
                    EngPhrase = "He will be her writer.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "writer",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Мы не будем их гидами.",
                    EngPhrase = "We will not be their guides.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "guides",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = true
                        }
                    }
                }
            };

            SaveExercises(exerciseRepository, dbExercises);
        }

        private static void AddExercisesToLesson3(IExerciseRepository exerciseRepository, LessonDB lessonDB)
        {
            var dbExercises = new List<ExerciseDB>()
            {
                new ExerciseDB()
                {
                    RusPhrase = "Тебе хочется пить?",
                    EngPhrase = "Do you want to drink?",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "want",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Ей хотелось забывать?",
                    EngPhrase = "Did she want to forget?",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "want",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Я был в музее.",
                    EngPhrase = "I was at the museum.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "museum",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Ей не нравилось показывать.",
                    EngPhrase = "She didn't like to show.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "like",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true
                        }
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Она в лифте?",
                    EngPhrase = "Is she in the elevator?",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "elevator",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        }
                    }
                }
            };

            SaveExercises(exerciseRepository, dbExercises);
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

            SaveExercises(exerciseRepository, dbExercises);
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

            SaveExercises(exerciseRepository, dbExercises);
        }

        private static void SaveExercises(IExerciseRepository exerciseRepository, IEnumerable<ExerciseDB> dbExercises)
        {
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
