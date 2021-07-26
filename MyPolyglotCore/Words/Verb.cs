using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MyPolyglotCore.Words
{
    public class Verb : Word
    {
        public string PastForm { get; set; } //2nd form
        public string PastParticipleForm { get; set; } // 3rd form
        public string PresentParticipleForm { get; } // ing
        public string ThirdPersonForm { get; } // s
        public IReadOnlyCollection<string> AdditionalForms { get; set; }
        public bool StressOnTheFinalSyllable { get; set; } = false;

        private const string IngEnding = "ing";
        private IReadOnlyCollection<char> _consonants;
        private IReadOnlyCollection<char> _vowels;

        public Verb(string text, IReadOnlyCollection<char> consonants, IReadOnlyCollection<char> vowels, bool stressOnTheFinalSyllable = false)
        {
            Text = text;
            StressOnTheFinalSyllable = stressOnTheFinalSyllable;
            _consonants = consonants;
            _vowels = vowels;
            PresentParticipleForm = GeneratePresentParticipleForm();
        }

        public bool IsIrregularVerb(IEnumerable<Verb> vocabulary)
        {
            return vocabulary.FirstOrDefault(x => x.Text == Text) != null;
        }

        private string GeneratePresentParticipleForm()
        {
            var lengthOfText = Text.Length;
            var lastTwoChars = Text.Substring(lengthOfText - 2);

            if (StressOnTheFinalSyllable && _vowels.Contains(lastTwoChars[0]) && _consonants.Contains(lastTwoChars[1]))
            {
                return Text + lastTwoChars[1] + IngEnding;
            }

            if (Text.EndsWith("ie"))
            {
                return Text.Substring(0, lengthOfText - 2) + 'y' + IngEnding;
            }

            if (Text.EndsWith("e"))
            {
                return Text.Substring(0, lengthOfText - 1) + IngEnding;
            }

            return Text + IngEnding;
        }

        private string GenerateThirdPersonForm()
        {
            var endingsTwoChars = new List<string>() { "ch", "s", "sh", "x", "z" };

            endingsTwoChars.ForEach(x => Text.EndsWith(x) );


            foreach (var ending in endingsTwoChars)
            {
                if (Text.EndsWith(ending))
                {
                    return Text + "es";
                };
            }

            return null;
        }
    }
}