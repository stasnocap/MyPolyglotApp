using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MyPolyglotCore.Words
{
    public class Verb : Word
    {
        public string PastTense { get; set; }
        public string PastParticle { get; set; }

        public bool IsIrregularVerb(IEnumerable<Verb> vocabulary)
        {
            return vocabulary.FirstOrDefault(x => x.Text == Text) != null;
        }
    }
}