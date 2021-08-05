using System.Collections.Generic;

namespace MyPolyglotWeb.Models.ViewModels
{
    public class AddExerciseVM
    {
        public string LessonId { get; set; }
        public string RusPhrase { get; set; }
        public string EngPhrase { get; set; }
        public IEnumerable<UnrecognizedWordVM> UnrecognizedWords { get; set; }
    }
}