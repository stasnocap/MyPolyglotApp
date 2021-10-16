using MyPolyglotCore.Words;
using System.Collections.Generic;

namespace MyPolyglotCore.Interfaces
{
    public interface IOptionsGenerator
    {
        IEnumerable<string> GetOptions(Word word);
    }
}