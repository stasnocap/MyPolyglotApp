using MyPolyglotCore;

namespace MyPolyglotWeb.Models.DomainModels
{
    public class UnrecognizedWordDB : BaseDB
    {
        public string Text { get; set; }
        public UnrecognizableTypes Type { get; set; }
        public virtual ExerciseDB Exercise { get; set; }
    }
}
