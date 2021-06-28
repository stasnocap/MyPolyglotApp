using System.Collections.Generic;

namespace PolyglotWeb.Models.ViewModels
{
    public class LessonViewModel
    {
        public long Id { get; set; }
        public Dictionary<int, string> Phrase { get; set; }
        public Dictionary<int, string> RightAnswer { get; set; }
        public int NumberOfRandomPhrase { get; set; }
    }
}