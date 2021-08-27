using System.Collections.Generic;

namespace MyPolyglotWeb.Models.DomainModels
{
    public class ExerciseDB : BaseDB
    {
        public string RusPhrase { get; set; }
        public virtual string EngPhrase { get; set; }
        public virtual IEnumerable<UnrecognizedWordDB> UnrecognizedWords { get; set; }
        public virtual LessonDB Lesson { get; set; }
    }
}