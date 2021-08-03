using MyPolyglotWeb.Models.DomainModels.DomainWords;
using System.Collections.Generic;

namespace MyPolyglotWeb.Models.DomainModels
{
    public class ExerciseDB : BaseDB
    {
        public string RusPhrase { get; set; }
        public virtual IEnumerable<WordDB> EngPhrase { get; set; }
        public virtual LessonDB Lesson { get; set; }
    }
}