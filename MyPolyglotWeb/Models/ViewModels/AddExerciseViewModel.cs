using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyPolyglotCore;
using MyPolyglotCore.Words;

namespace MyPolyglotWeb.Models.ViewModels
{
    public class AddExerciseViewModel
    {
        public string LessonId { get; set; }
        public string RusPhrase { get; set; }
        public string EngPhrase { get; set; }
        public List<UnrecognizedWord> UnrecognizedWords { get; set; }
    }
}