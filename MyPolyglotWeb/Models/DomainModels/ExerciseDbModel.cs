using MyPolyglotWeb.Models.DomainModels.Words;
using System.Collections.Generic;

namespace MyPolyglotWeb.Models.DomainModels
{
    public class ExerciseDbModel : BaseDbModel
    {
        public string RusPhrase { get; set; }
        public virtual List<WordDbModel> EngPhrase { get; set; }
        public virtual LessonDbModel Lesson { get; set; }
    }
}