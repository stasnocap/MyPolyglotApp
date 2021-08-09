using System;
using System.Collections.Generic;
using System.Linq;

namespace MyPolyglotCore.Words
{
    public class PrimaryVerb : Verb
    {
        public IReadOnlyCollection<string> NegativeForms { get; }
        public IReadOnlyCollection<string> AdditionalForms { get; }

        public PrimaryVerb(string text, string pastForm, string pastParticipleForm, string presentParticipleForm, 
            string thirdPersonForm, IReadOnlyCollection<string> negativeForms)
            : base(text, pastForm, pastParticipleForm, presentParticipleForm, thirdPersonForm, false)
        {
            NegativeForms = negativeForms;
            AdditionalForms = new HashSet<string>();
        }

        public PrimaryVerb(string text, string pastForm, string pastParticipleForm, string presentParticipleForm,
            string thirdPersonForm, IReadOnlyCollection<string> negativeForms, IReadOnlyCollection<string> additionalForms)
            : base(text, pastForm, pastParticipleForm, presentParticipleForm, thirdPersonForm, false)
        {
            NegativeForms = negativeForms;
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
                || NegativeForms.Where(x => word.Text == x).Any() 
                || AdditionalForms.Where(x => word.Text == x).Any();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Text, PastForm, PastParticipleForm, PastParticipleForm, ThirdPersonForm, StressOnTheFinalSyllable,
                NegativeForms, AdditionalForms);
        }
    }
}
