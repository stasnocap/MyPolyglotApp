using Application.Common.Interfaces.Persistence.Practice;
using Application.Common.Interfaces.Persistence.Vocabulary;
using Application.Common.Interfaces.Services;
using Domain.Practice.Exercises;
using Domain.Practice.Exercises.Services;
using Domain.Practice.Lessons;
using Domain.Practice.Scores;

namespace Application.Practice.Exercises.Common;

public class ExerciseConverter(IVocabularyRepository _vocabularyRepository,
    IScoreRepository _scoreRepository,
    IUserContext _userContext)
{
    private const int WordGroupSize = 6;
    private const int RightAnswerCount = 1;
    private const int RandomWordsCount = WordGroupSize - RightAnswerCount;

    public async Task<ExerciseResult> ConvertAsync(Exercise exercise, Lesson lesson, CancellationToken cancellationToken)
    {
        List<ExerciseResult.WordGroup> wordGroups = [];

        foreach (var word in exercise.Words.OrderBy(x => x.Number.Value))
        {
            var words = await _vocabularyRepository.GetRandomAsync(word, RandomWordsCount, cancellationToken);

            WordDecorator.Decorate(word, words);

            words.Insert(Random.Shared.Next(words.Count), word.Text.Value);

            wordGroups.Add(new ExerciseResult.WordGroup(words, word.Type));
        }

        var currentUserId = _userContext.GetCurrentUserId();
        
        Score? score = null;
        if (currentUserId is not null)
        {
            score = await _scoreRepository.GetAsync(lesson.Id, currentUserId.Value, cancellationToken);
        }

        return new ExerciseResult(exercise, lesson, score, wordGroups);
    }
}