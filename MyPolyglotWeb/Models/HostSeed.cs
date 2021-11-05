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
            }
            return host;
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
