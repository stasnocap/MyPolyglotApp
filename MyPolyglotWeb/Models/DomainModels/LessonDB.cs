using System.Collections.Generic;

namespace MyPolyglotWeb.Models.DomainModels
{
    public class LessonDB : BaseDB
    {
        public string LessonName { get; set; }
        public virtual List<ExerciseDB> Exercises { get; set; }
    }
}
