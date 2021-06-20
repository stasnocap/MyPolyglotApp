using System.Collections.Generic;

namespace MyPolyglotCore
{
    public class Lesson
    {
        public long Id { get; set; }
        public IEnumerable<Exercise> Exercises { get; set; }
    }
}
