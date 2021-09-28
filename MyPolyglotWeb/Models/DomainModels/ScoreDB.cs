namespace MyPolyglotWeb.Models.DomainModels
{
    public class ScoreDB : BaseDB
    {
        public virtual LessonDB Lesson { get; set; }
        public virtual UserDB User { get; set; }
        public virtual int Points { get; set; }
    }
}
