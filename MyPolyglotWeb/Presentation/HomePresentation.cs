using System;
using System.Collections.Generic;
using MyPolyglotCore;
using MyPolyglotWeb.Models.ViewModels;

namespace MyPolyglotWeb.Presentation
{
    public class HomePresentation
    {
        public LessonVM GetLessonViewModel(long id)
        {
            return new LessonVM()
            {
                Id = id,
                Lesson = new Lesson()
            };
        }
    }
}