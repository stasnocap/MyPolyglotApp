namespace MyPolyglotWeb.Models.DomainModels.Words
{
    public class WordDbModel : BaseDbModel
    {
        public string Text { get; set; }
        public virtual ExerciseDbModel Exercise { get; set; }
    }
}