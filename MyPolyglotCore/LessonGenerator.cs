using System;
using System.Collections.Generic;
using MyPolyglotCore.Words;
using MyPolyglotCore.Words.Pronouns;

namespace MyPolyglotCore
{
    public class LessonGenerator
    {
        private readonly Random _random = new Random();
        private readonly Vocabulary _vocabulary = new Vocabulary();

        public const byte NumberOfExerciseInLesson = 10;

        public Lesson GenerateFirstLesson()
        {
            var lesson = new Lesson();
            var exercises = new List<Exercise>();

            for (int i = 0; i < NumberOfExerciseInLesson; i++)
            {
                var exercise = new Exercise(_vocabulary);
                var structure = new List<Word>() { new SubjectPronoun(), new Verb() };
                foreach (var word in structure)
                {
                    var vocabulary = _vocabulary.GetVocabulary(word);
                    word.Text = vocabulary[_random.Next(vocabulary.Count)].Text;
                    exercise.EngPhrase.Add(word);
                    exercise.RusPhrase += word.Text + " ";
                }
                exercises.Add(exercise);
            }

            lesson.Exercises = exercises;
            return lesson;
        }
    }
}