using System;

namespace MyPolyglotCore.Words
{
    public class LetterNumber : Word
    {
        public int Number { get; }

        public LetterNumber(string text, int number) : base(text)
        {
            Number = number;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Text, Number);
        }
    }
}
