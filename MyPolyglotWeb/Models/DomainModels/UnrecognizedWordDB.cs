using MyPolyglotCore;

namespace MyPolyglotWeb.Models.DomainModels
{
    public class UnrecognizedWordDB : BaseDB
    {
        public string Text { get; set; }
        public UnrecognizableTypes Type { get; set; }
        public bool StressOnTheFinalSyllableInRegularVerb { get; set; }
        public int SyllablesInRegularComparisonAdjective { get; set; }
        public bool WasRecognizedFromPluralFormInNoun { get; set; }
        public virtual ExerciseDB Exercise { get; set; }
    }
}
