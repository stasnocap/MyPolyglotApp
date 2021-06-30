using System;
using System.Collections.Generic;
using MyPolyglotWeb.Models.ViewModels;

namespace MyPolyglotWeb.Presentation
{
    public class HomePresentation
    {
        public LessonViewModel GetLessonViewModel(long id)
        {
            var phrase = new Dictionary<int, string>();
            var rightAnswer = new Dictionary<int, string>();
            phrase.Add(0, "Нам нравилось есть.");
            rightAnswer.Add(0, "We liked to eat.");
            phrase.Add(1, "Ему хочется делать.");
            rightAnswer.Add(1, "He wants to make.");
            var numberOfRandomPhrase = GetRandomPhrase(phrase.Count);
            return new LessonViewModel()
            {
                Id = id,
                Phrase = phrase,
                RightAnswer = rightAnswer,
                NumberOfRandomPhrase = numberOfRandomPhrase
            };
        }

        private int GetRandomPhrase(int maxValue)
        {
            var random = new Random();
            return random.Next(maxValue);
        }
    }
}