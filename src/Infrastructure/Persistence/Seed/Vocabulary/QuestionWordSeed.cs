using Domain.Common.ValueObjects;
using Domain.Vocabulary.QuestionWords;
using Domain.Vocabulary.QuestionWords.ValueObjects;

namespace Infrastructure.Persistence.Seed.Vocabulary;

public static class QuestionWordSeed
{
    public static IReadOnlyList<QuestionWord> GetQuestionWords()
    {
        return
        [
            QuestionWord.Create(QuestionWordId.Create(Guid.Parse("377f7b4a-765b-4ac4-87e0-343b645cbc7c")), Text.Create("what").Value), 
            QuestionWord.Create(QuestionWordId.Create(Guid.Parse("3db6df5d-e140-4d7f-a231-c9a356e725fe")), Text.Create("who").Value), 
            QuestionWord.Create(QuestionWordId.Create(Guid.Parse("c92e0865-0310-4f68-89f5-6f23c38c40b2")), Text.Create("where").Value), 
            QuestionWord.Create(QuestionWordId.Create(Guid.Parse("9dffa778-547f-45e5-8e6e-22bdaef6d2f9")), Text.Create("when").Value), 
            QuestionWord.Create(QuestionWordId.Create(Guid.Parse("95aaeb38-63a9-4933-9aa0-78363d5ce039")), Text.Create("why").Value), 
            QuestionWord.Create(QuestionWordId.Create(Guid.Parse("28a50d80-9744-419f-ab08-a69cfcc80fd4")), Text.Create("how").Value), 
        ];
    }
}