using System;
using System.Collections.Generic;
using MyPolyglotCore;
using MyPolyglotCore.Words;
using MyPolyglotCore.Words.Pronouns;

namespace MyPolyglot
{
    public class LessonGenerator
    {
        private readonly Random _random = new Random();
        private readonly Vocabulary _vocabulary = new Vocabulary();

        public Lesson Generate()
        {
            var lesson = new Lesson();
            var exercises = new List<Exercise>();

            for (int i = 0; i < 10; i++)
            {
                var exercise = new Exercise(_vocabulary);
                var structure = new List<Word>() { new SubjectPronoun(), new Verb() };
                foreach (var word in structure)
                {
                    var vocabulary = exercise.Vocabulary.GetVocabulary(word);
                    word.Text = vocabulary[_random.Next(vocabulary.Length)];
                    exercise.RightAnswer.Add(word);
                    exercise.Sentence += word.Text + " ";
                }
                exercises.Add(exercise);
            }

            lesson.Exercises = exercises;
            return lesson;
        }
    }
}