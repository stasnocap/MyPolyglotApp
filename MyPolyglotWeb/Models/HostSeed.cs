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
                AddExercisesToLesson21(exerciseRepository, lessonRepository.Get(21));
                AddExercisesToLesson22(exerciseRepository, lessonRepository.Get(22));
                AddExercisesToLesson23(exerciseRepository, lessonRepository.Get(23));
                AddExercisesToLesson24(exerciseRepository, lessonRepository.Get(24));
                AddExercisesToLesson25(exerciseRepository, lessonRepository.Get(25));
                AddExercisesToLesson26(exerciseRepository, lessonRepository.Get(26));
                AddExercisesToLesson27(exerciseRepository, lessonRepository.Get(27));
            }
            return host;
        }

        private static void AddExercisesToLesson27(IExerciseRepository exerciseRepository, LessonDB lessonDB)
        {
            AddExercisesToLesson26(exerciseRepository, lessonDB);
            AddExercisesToLesson25(exerciseRepository, lessonDB);
            AddExercisesToLesson24(exerciseRepository, lessonDB);
        }

        private static void AddExercisesToLesson26(IExerciseRepository exerciseRepository, LessonDB lessonDB)
        {
            var dbExercises = new List<ExerciseDB>()
            {
                new ExerciseDB()
                {
                    RusPhrase = "Купив немного новой одежды, она почувствовала себя намного лучше.",
                    EngPhrase = "Having bought some new clothes she felt much better.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "cloth",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = true
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Посмотрев много журналов и газет, он начал писать свой доклад.",
                    EngPhrase = "Having looked through a lot of jounals and papers he began to write his report.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "look",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "journals",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = true
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "papers",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = true
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "report",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    },
                },
                new ExerciseDB()
                {
                    RusPhrase = "Приняв мой совет, она последовала ему.",
                    EngPhrase = "Having taken my advice she followed it.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "advice",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "follow",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = false
                        },
                    },
                },
                new ExerciseDB()
                {
                    RusPhrase = "Заплатив штраф, он больше не нарушал закон.",
                    EngPhrase = "Having paid the fine he did not break the law again.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "fine",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    },
                },
                new ExerciseDB()
                {
                    RusPhrase = "Обыскав квартиру, они не не нашли никаих доказательств.",
                    EngPhrase = "Having sought the flat they found no evidence.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "flat",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "evidence",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = false
                        },
                    },
                },
            };

            SaveExercises(exerciseRepository, dbExercises, lessonDB.Id);
        }

        private static void AddExercisesToLesson25(IExerciseRepository exerciseRepository, LessonDB lessonDB)
        {
            var dbExercises = new List<ExerciseDB>()
            {
                new ExerciseDB()
                {
                    RusPhrase = "Я был разочарован услышать, что все больше и больше людей теряют свою работу.",
                    EngPhrase = "I was disappointed to hear that more and more people lose their jobs.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "disappoint",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true,
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Измученный, он провалился в сон.",
                    EngPhrase = "Exhausted, he fell asleep.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "exhausted",
                            Type = UnrecognizableTypes.Adjective,
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "asleep",
                            Type = UnrecognizableTypes.Adjective,
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Прибор, купленный в специализированнмом магазине, имеет гарантию.",
                    EngPhrase = "The appliance bought from the specialized shop has a guarantee.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "appliance",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "specialized",
                            Type = UnrecognizableTypes.Adjective,
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "shop",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "guarantee",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Они не смогли оправиться от проигранной войны.",
                    EngPhrase = "They could not recover from the lost war.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "recover",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = false,
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "После компьютерного сбоя мы не смогли восстановить потерянные данные.",
                    EngPhrase = "After computer breaking down we could not restore the lost data.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "computer",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "restore",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true,
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "data",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    }
                },
            };

            SaveExercises(exerciseRepository, dbExercises, lessonDB.Id);
        }

        private static void AddExercisesToLesson24(IExerciseRepository exerciseRepository, LessonDB lessonDB)
        {
            var dbExercises = new List<ExerciseDB>()
            {
                new ExerciseDB()
                {
                    RusPhrase = "Зная материал, вы можете получить отличную оценку.",
                    EngPhrase = "Knowing the material you can get an excellent mark.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "material",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "excellent",
                            Type = UnrecognizableTypes.Adjective,
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "mark",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Работая за компьютером постоянно он теряет свое зрение.",
                    EngPhrase = "Working on computer all the time he loses his eyesight.",
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
                            Text = "computer",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "all",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "eyesight",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Читая стихотворение ребоенок сделала несколько ошибок.",
                    EngPhrase = "Reading a poem the child made several mistakes.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "poem",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "several",
                            Type = UnrecognizableTypes.Adjective,
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "mistake",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Все большее число людей изучают английский.",
                    EngPhrase = "Growing number of people learn English.",
                    Lesson = lessonDB,
                },
                new ExerciseDB()
                {
                    RusPhrase = "Покупая машину, вам нужно получить страховку.",
                    EngPhrase = "Buying a car you need to get the insurance.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "need",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "insurance",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    }
                },
            };

            SaveExercises(exerciseRepository, dbExercises, lessonDB.Id);
        }

        private static void AddExercisesToLesson23(IExerciseRepository exerciseRepository, LessonDB lessonDB)
        {
            AddExercisesToLesson22(exerciseRepository, lessonDB);
            AddExercisesToLesson21(exerciseRepository, lessonDB);
            AddExercisesToLesson20(exerciseRepository, lessonDB);
        }

        private static void AddExercisesToLesson22(IExerciseRepository exerciseRepository, LessonDB lessonDB)
        {
            var dbExercises = new List<ExerciseDB>()
            {
                new ExerciseDB()
                {
                    RusPhrase = "Они будут разговаривать уже свыше часа, к тому моменту, когда приедет он.",
                    EngPhrase = "They will have been talking for over an hour, by the time, he arrives.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "talk",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true
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
                    RusPhrase = "К первому июня он будет работать на этам заводе уже двадцать лет.",
                    EngPhrase = "By the first of June he will have been working at this plant for twenty years.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "June",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "work",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "plant",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "К следующему рождеству я уже буду преподавать 10 лет.",
                    EngPhrase = "Next Christmas I will have been teaching for ten years.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "Christmas",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "next",
                            Type = UnrecognizableTypes.Adjective,
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Ты будешь ждать свыше двух часов, прежде чем ее самолет, наконец, приземлится?",
                    EngPhrase = "Will you have been waiting for more than two hours, when her plane finally arrives?",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "wait",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "plane",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "arrive",
                            Type = UnrecognizableTypes.Noun,
                            StressOnTheFinalSyllableInRegularVerb = true
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "В следующем месяце мы будем жить вместе уже 15 лет.",
                    EngPhrase = "Next month we will have been living together for fifteen years.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "live",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "together",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    }
                },
            };

            SaveExercises(exerciseRepository, dbExercises, lessonDB.Id);
        }

        private static void AddExercisesToLesson21(IExerciseRepository exerciseRepository, LessonDB lessonDB)
        {
            var dbExercises = new List<ExerciseDB>()
            {
                new ExerciseDB()
                {
                    RusPhrase = "С теп пор показатель быстро рос.",
                    EngPhrase = "Since then the index had been rising fast.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "index",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false,
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "fast",
                            Type = UnrecognizableTypes.Adjective,
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Его руки были грязные, он копал.",
                    EngPhrase = "His hands were dirty he had been digging.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "dirty",
                            Type = UnrecognizableTypes.Adjective,
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Они разговаривали больше часа, до того, как он пришел.",
                    EngPhrase = "They had been talking for over an hour before he arrived.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "talk",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true,
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "arrive",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true,
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Был час ночи, а соседкая собака лаяла уже 2 часа.",
                    EngPhrase = "It was one o'clock and the dog from next door had been barking for two hours.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "o'clock",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false,
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "dog",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "next",
                            Type = UnrecognizableTypes.Adjective,
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "bark",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true,
                        },
                    }
                },
                new ExerciseDB()
                {
                    RusPhrase = "Моя собака играла уже полчаса перед тем, как мы пошли гулять.",
                    EngPhrase = "My dog had been playing for half an hour before we went for a walk.",
                    Lesson = lessonDB,
                    UnrecognizedWords = new List<UnrecognizedWordDB>()
                    {
                        new UnrecognizedWordDB()
                        {
                            Text = "dog",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false,
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "play",
                            Type = UnrecognizableTypes.RegularVerb,
                            StressOnTheFinalSyllableInRegularVerb = true
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "half",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                        new UnrecognizedWordDB()
                        {
                            Text = "walk",
                            Type = UnrecognizableTypes.Noun,
                            WasRecognizedFromPluralFormInNoun = false
                        },
                    }
                },
            };

            SaveExercises(exerciseRepository, dbExercises, lessonDB.Id);
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

            SaveExercises(exerciseRepository, dbExercises, lessonDB.Id);
        }

        private static void AddExercisesToLesson19(IExerciseRepository exerciseRepository, LessonDB lessonDB)
        {
            AddExercisesToLesson18(exerciseRepository, lessonDB);
            AddExercisesToLesson17(exerciseRepository, lessonDB);
            AddExercisesToLesson16(exerciseRepository, lessonDB);
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

            SaveExercises(exerciseRepository, dbExercises, lessonDB.Id);
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

            SaveExercises(exerciseRepository, dbExercises, lessonDB.Id);
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

            SaveExercises(exerciseRepository, dbExercises, lessonDB.Id);
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

            SaveExercises(exerciseRepository, dbExercises, lessonDB.Id);
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

            SaveExercises(exerciseRepository, dbExercises, lessonDB.Id);
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

            SaveExercises(exerciseRepository, dbExercises, lessonDB.Id);
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

            SaveExercises(exerciseRepository, dbExercises, lessonDB.Id);
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

            SaveExercises(exerciseRepository, dbExercises, lessonDB.Id);
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

            SaveExercises(exerciseRepository, dbExercises, lessonDB.Id);
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

            SaveExercises(exerciseRepository, dbExercises, lessonDB.Id);
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

            SaveExercises(exerciseRepository, dbExercises, lessonDB.Id);
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

            SaveExercises(exerciseRepository, dbExercises, lessonDB.Id);
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

            SaveExercises(exerciseRepository, dbExercises, lessonDB.Id);
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

            SaveExercises(exerciseRepository, dbExercises, lessonDB.Id);
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

            SaveExercises(exerciseRepository, dbExercises, lessonDB.Id);
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

            SaveExercises(exerciseRepository, dbExercises, lessonDB.Id);
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

            SaveExercises(exerciseRepository, dbExercises, lessonDB.Id);
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

            SaveExercises(exerciseRepository, dbExercises, lessonDB.Id);
        }

        private static void SaveExercises(IExerciseRepository exerciseRepository, IEnumerable<ExerciseDB> dbExercises, long lessonId)
        {
            foreach (var dbExercise in dbExercises)
            {
                if (!exerciseRepository.IsExist(dbExercise.EngPhrase, lessonId))
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
