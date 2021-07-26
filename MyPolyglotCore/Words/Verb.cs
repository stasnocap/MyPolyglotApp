using System;
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
        public bool StressOnTheFinalSyllable { get; set; } 

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
            var preLastChar = lastTwoChars[0];
            var lastChar = lastTwoChars[1];

            if (StressOnTheFinalSyllable && _vowels.Contains(preLastChar) && _consonants.Contains(lastChar))
            {
                return Text + lastChar + IngEnding;
            }

            if (preLastChar == 'i' && lastChar == 'e')
            {
                return Text.Substring(0, lengthOfText - 2) + 'y' + IngEnding;
            }

            if (lastChar == 'e')
            {
                return Text.Substring(0, lengthOfText - 1) + IngEnding;
            }

            return Text + IngEnding;
        }
    }
}