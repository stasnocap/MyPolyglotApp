using MyPolyglotWeb.Models.DomainModels.Words;
using System.Collections.Generic;

namespace MyPolyglotWeb.Models.DomainModels
{
    public class Exercise : BaseModel
    {
        public string RusPhrase { get; set; }
        public virtual List<Word> EngPhrase { get; set; }
        public virtual Lesson Lesson { get; set; }
    }
}