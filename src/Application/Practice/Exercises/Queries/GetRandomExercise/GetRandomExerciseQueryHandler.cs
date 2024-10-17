using Application.Common.Interfaces.Persistence.Practice;
using Application.Common.Interfaces.Persistence.Vocabulary;
using Application.Practice.Exercises.Common;
using Domain.Practice.Exercises.Services;
using Domain.Practice.Lessons.Errors;
using ErrorOr;
using MediatR;

namespace Application.Practice.Exercises.Queries.GetRandomExercise;

public class GetRandomExerciseQueryHandler(
    IExerciseRepository _exerciseRepository, 
    ILessonRepository _lessonRepository,
    IVocabularyRepository _vocabularyRepository) : IRequestHandler<GetRandomExerciseQuery, ErrorOr<ExerciseResult>>
{
    private const int WordGroupSize = 6;
    private const int RightAnswerCount = 1;
    private const int RandomWordsCount = WordGroupSize - RightAnswerCount;
    
    public async Task<ErrorOr<ExerciseResult>> Handle(GetRandomExerciseQuery request, CancellationToken cancellationToken)
    {
        var lessonNumber = await _lessonRepository.GetLessonNumberAsync(request.LessonId, cancellationToken);
        
        if (lessonNumber is null)
        {
            return LessonErrors.NotFound;
        }

        var exercise = await _exerciseRepository.GetRandomExerciseAsync(request.LessonId, cancellationToken);

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