using Domain.Common;
using Domain.Common.ValueObjects;
using Domain.Vocabulary.Languages.ValueObjects;

namespace Domain.Vocabulary.Languages;

public sealed class Language : BaseWord<LanguageId>
{
    private Language(LanguageId id, Text text) : base(id, text)
    {
    }

    public static Language Create(Text text)
    {
        return new Language(LanguageId.CreateUnique(), text);
    }

    public static Language Create(LanguageId languageId, Text text)
    {
        return new Language(languageId, text);
    }
}