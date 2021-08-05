using System.Collections.Generic;

namespace MyPolyglotWeb.Models.DomainModels
{
    public class LessonDB : BaseDB
    {
        public string LessonName { get; set; }
        public virtual IEnumerable<ExerciseDB> Exercises { get; set; }
    }
}
