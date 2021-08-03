using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyPolyglotCore;
using MyPolyglotCore.Words;

namespace MyPolyglotWeb.Models.ViewModels
{
    public class AddExerciseVM
    {
        public string LessonId { get; set; }
        public string RusPhrase { get; set; }
        public string EngPhrase { get; set; }
        public IEnumerable<UnrecognizedWordVM> UnrecognizedWords { get; set; }
        public IEnumerable<Word> RecognizedWords { get; set; }
    }
}