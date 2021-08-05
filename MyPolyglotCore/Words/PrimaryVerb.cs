namespace MyPolyglotCore.Words
{
    public class PrimaryVerb : Verb
    {
        public SingularOrPlural SingularOrPlural { get; set; }
        public PositiveOrNegative PositiveOrNegative { get; set; }

        public PrimaryVerb(string text, string pastForm, string pastParticipleForm, string presentParticipleForm, string thirdPersonForm,
            PositiveOrNegative positiveOrNegative = PositiveOrNegative.Positive, SingularOrPlural singularOrPlural = SingularOrPlural.Singular)
            : base(positiveOrNegative == PositiveOrNegative.Positive && !text.Equals("be") 
                  ? text 
                  : text + "n't", 
                  pastForm, 
                  pastParticipleForm, 
                  presentParticipleForm, 
                  thirdPersonForm)
        {
        }
    }

    public enum SingularOrPlural
    {
        Singular,
        Plural
    }

    public enum PositiveOrNegative
    {
        Positive,
        Negative
    }
}
