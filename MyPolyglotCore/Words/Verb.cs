using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPolyglotCore.Words
{
    public class Verb : Word
    {
        public string PastForm { get; } // 2nd form
        public string PastParticipleForm { get; } // 3rd form
        public string PresentParticipleForm { get; } // ing
        public string ThirdPersonForm { get; } // s
        public bool StressOnTheFinalSyllable { get; }
        public bool IsIrregularVerb { get; }

        public Verb(string text, string pastForm, string pastParticipleForm, bool stressOnTheFinalSyllable = false) : base(text)
        {
            StressOnTheFinalSyllable = stressOnTheFinalSyllable;
            PastForm = pastForm;
            PastParticipleForm = pastParticipleForm;
            PresentParticipleForm = GeneratePresentParticipleForm();
            ThirdPersonForm = GenerateThirdPersonForm();
            IsIrregularVerb = true;
        }

        public Verb(string text, bool stressOnTheFinalSyllable = false) : base(text)
        {
            StressOnTheFinalSyllable = stressOnTheFinalSyllable;
            PastForm = GeneratePastForm();
            PastParticipleForm = PastForm;
            PresentParticipleForm = GeneratePresentParticipleForm();
            ThirdPersonForm = GenerateThirdPersonForm();
            IsIrregularVerb = false;
        }

        protected Verb(string text, string pastForm, string pastParticipleForm, string presentParticipleForm, string thirdPersonForm) : base(text)
        {
            PastForm = pastForm;
            PastParticipleForm = pastParticipleForm;
            PresentParticipleForm = presentParticipleForm;
            ThirdPersonForm = thirdPersonForm;
            StressOnTheFinalSyllable = false;
            IsIrregularVerb = false;
        }

        public override bool Equals(object obj)
        {
            var word = obj as Word;

            if (word == null)
            {
                return false;
            }

            return base.Equals(obj)
                || PastForm == word.Text
                || PastParticipleForm == word.Text
                || PresentParticipleForm == word.Text
                || ThirdPersonForm == word.Text;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Text, PastForm, PastParticipleForm, PresentParticipleForm, 
                ThirdPersonForm, StressOnTheFinalSyllable);
        }

        private string GeneratePastForm()
        {
            var lastTwoChars = Text.Substring(Text.Length - 2);

            if (Vocabulary.Vowels.Contains(lastTwoChars[0]) && Vocabulary.Consonants.Contains(lastTwoChars[1]))
            {
                return Text + lastTwoChars[1] + Vocabulary.EdEnding;
            }

            if (Vocabulary.Vowels.Contains(lastTwoChars[0]) && Text.EndsWith('y'))
            {
                return Text + Vocabulary.EdEnding;
            }

            if (Text.EndsWith('y'))
            {
                return Text.Substring(0, Text.Length - 1) + "ied";
            }

            if (Text.EndsWith('e'))
            {
                return Text + 'd';
            }

            return Text + Vocabulary.EdEnding;
        }

        private string GeneratePresentParticipleForm()
        {
            var lastTwoChars = Text.Substring(Text.Length - 2);

            if (StressOnTheFinalSyllable && Vocabulary.Vowels.Contains(lastTwoChars[0]) && Vocabulary.Consonants.Contains(lastTwoChars[1]))
            {
                return Text + lastTwoChars[1] + Vocabulary.IngEnding;
            }

            if (Text.EndsWith("ie"))
            {
                return Text.Substring(0, Text.Length - 2) + 'y' + Vocabulary.IngEnding;
            }

            if (Text.EndsWith('e'))
            {
                return Text.Substring(0, Text.Length - 1) + Vocabulary.IngEnding;
            }

            return Text + Vocabulary.IngEnding;
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
            }

            if (Vocabulary.Consonants.Contains(lastTwoChars[0]) && lastTwoChars[1] == 'y')
            {
                return Text.Substring(0, Text.Length - 1) + "ies";
            }

            return Text + 's';
        }
    }
}