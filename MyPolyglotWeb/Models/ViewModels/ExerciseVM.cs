using System.Collections.Generic;

namespace MyPolyglotWeb.Models.ViewModels
{
    public class ExerciseVM
    {
        public long Id { get; set; }
        public string RusPhrase { get; set; }
        public string EngPhrase { get; set; }
        public IEnumerable<UnrecognizedWordVM> UnrecognizedWords { get; set; }
        public List<OptionsGroup> WordsGroups { get; set; }
    }
}
