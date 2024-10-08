using Domain.Common;
using Domain.Common.ValueObjects;
using Domain.Vocabulary.QuestionWords.ValueObjects;

namespace Domain.Vocabulary.QuestionWords;

public sealed class QuestionWord : BaseWord<QuestionWordId>
{
    private QuestionWord(QuestionWordId id, Text text) : base(id, text)
    {
    }

    public static QuestionWord Create(Text text)
    {
        return new QuestionWord(QuestionWordId.CreateUnique(), text);
    }

    public static QuestionWord Create(QuestionWordId questionWordId, Text text)
    {
        return new QuestionWord(questionWordId, text);
    }
}