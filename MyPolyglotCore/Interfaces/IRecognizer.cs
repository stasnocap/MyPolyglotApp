using MyPolyglotCore.Words;
using System.Collections.Generic;

namespace MyPolyglotCore.Interfaces
{
    public interface IRecognizer
    {
        IEnumerable<Word> RecognizedWords { get; }
        IEnumerable<Word> UnrecognizedWords { get; }
        void Recognize(string engPhrase);
    }
}