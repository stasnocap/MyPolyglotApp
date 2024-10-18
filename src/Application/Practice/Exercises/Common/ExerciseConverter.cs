using Application.Common.Interfaces.Persistence.Vocabulary;
using Domain.Practice.Exercises;
using Domain.Practice.Exercises.Services;
using Domain.Practice.Lessons.ValueObjects;

namespace Application.Practice.Exercises.Common;

public class ExerciseConverter(IVocabularyRepository _vocabularyRepository)
{
    private const int WordGroupSize = 6;
    private const int RightAnswerCount = 1;
    private const int RandomWordsCount = WordGroupSize - RightAnswerCount;

    public async Task<ExerciseResult> ConvertAsync(Exercise exercise, LessonNumber lessonNumber, CancellationToken cancellationToken)
    {
        List<ExerciseResult.WordGroup> wordGroups = [];

        foreach (var word in exercise.Words.OrderBy(x => x.Number.Value))
        {
            var words = await _vocabularyRepository.GetRandomAsync(word, RandomWordsCount, cancellationToken);

            WordDecorator.Decorate(word, words);
            
            words.Insert(Random.Shared.Next(RandomWordsCount), word.Text.Value);

            wordGroups.Add(new ExerciseResult.WordGroup(words, word.Type));
        }

        return new ExerciseResult(exercise.Id, lessonNumber, exercise.RusPhrase, wordGroups);
    }
}