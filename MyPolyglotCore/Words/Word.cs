namespace MyPolyglotCore.Words
{
    public class Word
    {
        public string Text { get; }

        public Word(string text)
        {
            Text = text;
        }

        public override bool Equals(object obj)
        {
            var word = obj as Word;

            if (word == null)
            {
                return false;
            }

            return Text.Equals(word.Text);
        }

        public override int GetHashCode()
        {
            return Text.GetHashCode();
        }
    }
}