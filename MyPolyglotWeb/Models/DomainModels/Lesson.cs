using System.Collections.Generic;

namespace MyPolyglotWeb.Models.DomainModels
{
    public class Lesson : BaseModel
    {
        public string LessonName { get; set; }
        public virtual List<Exercise> Exercises { get; set; }
    }
}
