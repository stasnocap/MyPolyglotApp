using System.Collections.Generic;

namespace MyPolyglotWeb.Models.ViewModels
{
    public class ExerciseVM
    {
        public long LessonId { get; set; }
        public long ExerciseId { get; set; }
        public string RusPhrase { get; set; }
        public List<OptionGroup> OptionGroups { get; set; }
        public string UserAnswer { get; set; }
    }
}
