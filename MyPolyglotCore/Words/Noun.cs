using System;
using System.Linq;

namespace MyPolyglotCore.Words
{
    public class Noun : Word
    {
        public string PluralForm { get; set; }
        public bool WasRecognizedFromPluralForm { get; set; }

        public Noun(string singleOrPlural, bool wasRecognizedFromPluralForm) : base(!wasRecognizedFromPluralForm ? singleOrPlural : null)
        {
            WasRecognizedFromPluralForm = wasRecognizedFromPluralForm;
            PluralForm = wasRecognizedFromPluralForm ? singleOrPlural : null;
        }

        public Noun(string text, string pluralForm) : base(text)
        {
            PluralForm = pluralForm;
        }

        public Noun(string text) : base(text)
        {
            PluralForm = GeneratePluralForm();
        }

        private string GeneratePluralForm()
        {
            if (Text.EndsWith("on") && Text[Text.Length - 3] != 'o')
            {
                return Text.Substring(0, Text.Length - 2) + "a";
            }

            if (Text.EndsWith("is"))
            {
                return Text.Substring(0, Text.Length - 2) + "es";
            }

            if (Text.EndsWith('f')
                && Text != "roof"
                && Text != "belief"
                && Text != "chef"
                && Text != "chief")
            {
                return Text.Substring(0, Text.Length - 1) + "ves";
            }

            if (Text.EndsWith("fe"))
            {
                return Text.Substring(0, Text.Length - 2) + "ves";
            }

            if (Text.EndsWith('y') && Vocabulary.Consonants.Contains(Text[Text.Length - 2]))
            {
                return Text.Substring(0, Text.Length - 1) + "ies";
            }

            if (Text.EndsWith('s')
                || Text.EndsWith("ss")
                || Text.EndsWith("sh")
                || Text.EndsWith("ch")
                || Text.EndsWith("x")
                || Text.EndsWith("z")
                || Text.EndsWith("es")
                || Text.EndsWith("o")
                && Text != "photo"
                && Text != "piano"
                && Text != "halo")
            {
                return Text + "es";
            }

            return Text + "s";
        }

        public override bool Equals(object obj)
        {
            var word = obj as Word;

            if (word == null)
            {
                return false;
            }

            return base.Equals(obj)
                || PluralForm == word.Text;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Text, PluralForm);
        }
    }
}