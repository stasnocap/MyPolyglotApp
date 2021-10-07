using System;
using System.Linq;

namespace MyPolyglotCore.Words
{
    public class ComparisonAdjective : Word
    {
        public string ComparativeForm { get; set; }
        public string SuperlativeForm { get; set; }
        public int CountOfSyllables { get; set; }

        public ComparisonAdjective(string text, string comparativeForm, string superlativeForm) : base(text)
        {
            ComparativeForm = comparativeForm;
            SuperlativeForm = superlativeForm;
        }

        public ComparisonAdjective(string text, int countOfSyllables) : base(text)
        {
            CountOfSyllables = countOfSyllables;
            ComparativeForm = GenerateComparativeForm();
            SuperlativeForm = GenerateSuperlativeForm();
        }

        public override bool Equals(object obj)
        {
            var word = obj as Word;

            if (word == null)
            {
                return false;
            }

            return base.Equals(obj)
                || ComparativeForm == word.Text
                || SuperlativeForm == word.Text;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Text, ComparativeForm, SuperlativeForm);
        }

        private string GenerateComparativeForm()
        {
            if (CountOfSyllables == 1)
            {
                if (Text.EndsWith('e'))
                {
                    return Text + 'r';
                }

                if (Text[Text.Length - 1] != 'w'
                    && Vocabulary.Consonants.Contains(Text[Text.Length - 1])
                    && Vocabulary.Vowels.Contains(Text[Text.Length - 2])
                    && !Vocabulary.Vowels.Contains(Text[Text.Length - 3]))
                {
                    return Text + Text[Text.Length - 1] + "er";
                }

                return Text + "er";
            }

            if (CountOfSyllables == 2)
            {
                if (Text == "polite")
                {
                    return "politer";
                }

                if (Text.EndsWith('y'))
                {
                    return Text.Substring(0, Text.Length - 1) + "ier";
                }

                if (Text.EndsWith("le"))
                {
                    return Text + "r";
                }

                if (Text.EndsWith("er") || Text.EndsWith("ow"))
                {
                    return Text + "er";
                }

                return "more " + Text;
            }

            return "more " + Text;
        }

        private string GenerateSuperlativeForm()
        {
            if (CountOfSyllables == 1)
            {
                if (Text.EndsWith('e'))
                {
                    return Text + "st";
                }

                if (Text[Text.Length - 1] != 'w'
                    && Vocabulary.Consonants.Contains(Text[Text.Length - 1])
                    && Vocabulary.Vowels.Contains(Text[Text.Length - 2])
                    && !Vocabulary.Vowels.Contains(Text[Text.Length - 3]))
                {
                    return Text + Text[Text.Length - 1] + "est";
                }

                return Text + "est";
            }

            if (CountOfSyllables == 2)
            {
                if (Text == "polite")
                {
                    return "politest";
                }

                if (Text.EndsWith('y'))
                {
                    return Text.Substring(0, Text.Length - 1) + "iest";
                }

                if (Text.EndsWith("le"))
                {
                    return Text + "st";
                }

                if (Text.EndsWith("er") || Text.EndsWith("ow"))
                {
                    return Text + "est";
                }

                return "most " + Text;
            }

            return "most " + Text;
        }
    }
}
