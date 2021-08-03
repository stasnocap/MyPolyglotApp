namespace MyPolyglotWeb.Models.DomainModels.DomainWords
{
    public class WordDB : BaseDB
    {
        public string Text { get; set; }
        public virtual ExerciseDB Exercise { get; set; }
    }
}