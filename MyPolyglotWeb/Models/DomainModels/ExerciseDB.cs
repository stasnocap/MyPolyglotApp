using MyPolyglotWeb.Models.DomainModels.Words;
using System.Collections.Generic;

namespace MyPolyglotWeb.Models.DomainModels
{
    public class ExerciseDB : BaseDB
    {
        public string RusPhrase { get; set; }
        public virtual List<WordDB> EngPhrase { get; set; }
        public virtual LessonDB Lesson { get; set; }
    }
}