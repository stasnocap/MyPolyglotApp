namespace MyPolyglotWeb.Models.DomainModels.Words
{
    public class Word : BaseModel
    {
        public string Text { get; set; }
        public virtual Exercise Exercise { get; set; }
    }
}