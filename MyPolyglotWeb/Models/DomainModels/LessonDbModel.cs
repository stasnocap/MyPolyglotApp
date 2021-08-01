using System.Collections.Generic;

namespace MyPolyglotWeb.Models.DomainModels
{
    public class LessonDbModel : BaseDbModel
    {
        public string LessonName { get; set; }
        public virtual List<ExerciseDbModel> Exercises { get; set; }
    }
}
