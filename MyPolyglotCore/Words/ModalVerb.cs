using System;

namespace MyPolyglotCore.Words
{
    public class ModalVerb : Word
    {
        public string FullNegativeForm { get; }
        public string ShortNegativeForm { get; }

        public ModalVerb(string text, string fullNegativeForm, string shortNegativeForm) : base(text)
        {
            FullNegativeForm = fullNegativeForm;
            ShortNegativeForm = shortNegativeForm;
        }

        public override bool Equals(object obj)
        {
            var word = obj as Word;

            if (word == null)
            {
                return false;
            }

            return base.Equals(word)
                || ShortNegativeForm == word.Text;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Text, ShortNegativeForm);
        }
    }
}
