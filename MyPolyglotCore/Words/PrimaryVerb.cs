using System.Collections.Generic;

namespace MyPolyglotCore.Words
{
    public class PrimaryVerb : Verb
    {
        public IReadOnlyCollection<string> NegativeForms { get; }
        public IReadOnlyCollection<string> AdditionalForms { get; }

        public PrimaryVerb(string text, string pastForm, string pastParticipleForm, string presentParticipleForm, 
            string thirdPersonForm, IReadOnlyCollection<string> additionalForms, IReadOnlyCollection<string> negativeForms)
            : base(text, pastForm, pastParticipleForm, presentParticipleForm, thirdPersonForm)
        {
            AdditionalForms = additionalForms;
            NegativeForms = negativeForms;
        }
    }
}
