using System;

namespace MyPolyglotCore.Words
{
    public class Word : IEquatable<Word>
    {
        public string Text { get; }

        public Word(string text)
        {
            Text = text;
        }

        public bool Equals(Word other)
        {
            return Text == other?.Text;
        }
        public override bool Equals(object obj) => Equals(obj as Word);
        public override int GetHashCode() => Text.GetHashCode();
    }
}