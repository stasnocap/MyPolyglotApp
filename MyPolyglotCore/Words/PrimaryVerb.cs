using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPolyglotCore.Words
{
    public class PrimaryVerb : Verb
    {
        public IEnumerable<string> ShortNegativeForms { get; }
        public IEnumerable<string> FullNegativeForms { get; }
        public IEnumerable<string> AdditionalForms { get; }

        public PrimaryVerb(string text, string pastForm, string pastParticipleForm, string presentParticipleForm, 
            string thirdPersonForm, IEnumerable<string> shortNegativeForms, IEnumerable<string> fullNegativeForms)
            : base(text, pastForm, pastParticipleForm, presentParticipleForm, thirdPersonForm)
        {
            ShortNegativeForms = shortNegativeForms;
            FullNegativeForms = fullNegativeForms;
        }

        public PrimaryVerb(string text, string pastForm, string pastParticipleForm, string presentParticipleForm,
            string thirdPersonForm, IEnumerable<string> shortNegativeForms, IEnumerable<string> fullNegativeForms,
            IEnumerable<string> additionalForms)
            : base(text, pastForm, pastParticipleForm, presentParticipleForm, thirdPersonForm)
        {
            ShortNegativeForms = shortNegativeForms;
            FullNegativeForms = fullNegativeForms;
            AdditionalForms = additionalForms;
        }

        public override bool Equals(object obj)
        {
            var word = obj as Word;

            if (word == null)
            {
                return false;
            }

            return base.Equals(obj)
                || ShortNegativeForms.Where(x => word.Text == x).Any()
                || FullNegativeForms.Where(x => word.Text == x).Any()
                || AdditionalForms != null && AdditionalForms.Where(x => word.Text == x).Any();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Text, PastForm, PastParticipleForm, ThirdPersonForm, StressOnTheFinalSyllable,
                ShortNegativeForms, FullNegativeForms, AdditionalForms);
        }
    }
}
