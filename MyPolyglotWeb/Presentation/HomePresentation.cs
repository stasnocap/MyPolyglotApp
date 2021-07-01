using System;
using System.Collections.Generic;
using MyPolyglotCore;
using MyPolyglotWeb.Models.ViewModels;

namespace MyPolyglotWeb.Presentation
{
    public class HomePresentation
    {
        public LessonViewModel GetLessonViewModel(long id)
        {
            var generator = new LessonGenerator();
            var lesson = generator.GenerateFirstLesson();
            return new LessonViewModel()
            {
                Id = id,
                Lesson = lesson
            };
        }

        private int GetRandomPhrase(int maxValue)
        {
            var random = new Random();
            return random.Next(maxValue);
        }
    }
}