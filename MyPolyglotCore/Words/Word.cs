using System;

namespace MyPolyglotCore.Words
{
    public class Word : IEquatable<Word>
    {
        public string Text { get; set; }

        public bool Equals(Word other)
        {
            return Text == other?.Text;
        }
        public override bool Equals(object obj) => Equals(obj as Word);
        public override int GetHashCode() => Text.GetHashCode();
    }
}