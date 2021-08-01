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
        public IReadOnlyCollection<string> AdditionalForms { get; set; }
        public bool StressOnTheFinalSyllable { get; }

        public Verb(string text, string pastForm, string pastParticipleForm, bool stressOnTheFinalSyllable = false) : base(text)
        {
            StressOnTheFinalSyllable = stressOnTheFinalSyllable;
            PastForm = pastForm;
            PastParticipleForm = pastParticipleForm;
            PresentParticipleForm = GeneratePresentParticipleForm();
            ThirdPersonForm = GenerateThirdPersonForm();
        }

        public Verb(string text, string pastForm, string pastParticipleForm, IReadOnlyCollection<string> additionalForms,bool stressOnTheFinalSyllable = false) : base(text)
        {
            StressOnTheFinalSyllable = stressOnTheFinalSyllable;
            PastForm = pastForm;
            PastParticipleForm = pastParticipleForm;
            AdditionalForms = additionalForms;
            PresentParticipleForm = GeneratePresentParticipleForm();
            ThirdPersonForm = GenerateThirdPersonForm();
        }

        public Verb(string text, bool stressOnTheFinalSyllable = false) : base(text)
        {
            StressOnTheFinalSyllable = stressOnTheFinalSyllable;
            PastForm = GeneratePastForm();
            PastParticipleForm = PastForm;
            PresentParticipleForm = GeneratePresentParticipleForm();
            ThirdPersonForm = GenerateThirdPersonForm();
        }

        public override bool Equals(object obj)
        {
            var word = obj as Word;

            if (word == null)
            {
                return false;
            }

            bool existInAdditionalForms = false;
            if (AdditionalForms != null && AdditionalForms.Where(x => x.Equals(word.Text)).Any())
            {
                existInAdditionalForms = true;
            }

            return word.Text.Equals(Text)
                || word.Text.Equals(PastForm)
                || word.Text.Equals(PastParticipleForm)
                || word.Text.Equals(PresentParticipleForm)
                || word.Text.Equals(ThirdPersonForm)
                || existInAdditionalForms;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Text, PastForm, PastParticipleForm, PresentParticipleForm, 
                ThirdPersonForm, AdditionalForms, StressOnTheFinalSyllable);
        }

        public bool IsIrregularVerb(IEnumerable<Verb> vocabulary)
        {
            return vocabulary.FirstOrDefault(x => x.Text == Text) != null;
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