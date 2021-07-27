using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MyPolyglotCore.Words
{
    public class Verb : Word
    {
        public string PastForm { get; set; } // 2nd form
        public string PastParticipleForm { get; set; } // 3rd form
        public string PresentParticipleForm { get; } // ing
        public string ThirdPersonForm { get; } // s
        public IReadOnlyCollection<string> AdditionalForms { get; set; }
        public bool StressOnTheFinalSyllable { get; }

        public Verb(string text, bool stressOnTheFinalSyllable = false) : base(text)
        {
            StressOnTheFinalSyllable = stressOnTheFinalSyllable;
            StressOnTheFinalSyllable = stressOnTheFinalSyllable;
            _consonants = consonants;
            _vowels = vowels;
            PresentParticipleForm = GeneratePresentParticipleForm();
            ThirdPersonForm = GenerateThirdPersonForm();
        }

        public bool IsIrregularVerb(IEnumerable<Verb> vocabulary)
        {
            return vocabulary.FirstOrDefault(x => x.Text == Text) != null;
        }

        private string GeneratePresentParticipleForm()
        {
            var lengthOfText = Text.Length;
            var lastTwoChars = Text.Substring(lengthOfText - 2);

            if (StressOnTheFinalSyllable && Vocabulary.Vowels.Contains(lastTwoChars[0]) && Vocabulary.Consonants.Contains(lastTwoChars[1]))
            {
                return Text + lastTwoChars[1] + Vocabulary.IngEnding;
            }

            if (Text.EndsWith("ie"))
            {
                return Text.Substring(0, lengthOfText - 2) + 'y' + Vocabulary.IngEnding;
            }

            if (Text.EndsWith("e"))
            {
                return Text.Substring(0, lengthOfText - 1) + Vocabulary.IngEnding;
            }

        private string GenerateThirdPersonForm()
        {
            var lastTwoChars = Text.Substring(Text.Length - 2);

            foreach (var ending in Vocabulary.ThirdPersonESEndings)
            {
                if (Text.EndsWith(ending))
                {
                    return Text + "es";
                };
            if (preLastChar == 'i' && lastChar == 'e')
            {
                return Text.Substring(0, lengthOfText - 2) + 'y' + IngEnding;
            }
                return Text.Substring(0, Text.Length - 1) + "ies";
            if (Vocabulary.Consonants.Contains(lastTwoChars[0]) && lastTwoChars[1] == 'y')
            {
                return Text.Substring(0, lengthOfText - 1) + IngEnding;
            }

            return Text + "s";
        }
    }
}