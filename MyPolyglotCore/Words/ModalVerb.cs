using System;

namespace MyPolyglotCore.Words
{
    public class ModalVerb : Word
    {
        public string NegativeForm { get; }

        public ModalVerb(string text) : base(text)
        {
            NegativeForm = GenerateNegativeForm();
        }

        private string GenerateNegativeForm()
        {
            if (Text == "may" || Text == "shall")
            {
                return Text + " not";
            }

            if (Text == "will")
            {
                return "won't";
            }

            if (Text.EndsWith('n'))
            {
                return Text + "'t";
            }

            return Text + "n't";
        }

        public override bool Equals(object obj)
        {
            var word = obj as Word;

            if (word == null)
            {
                return false;
            }

            return base.Equals(word)
                || NegativeForm == word.Text;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Text, NegativeForm);
        }
    }
}
