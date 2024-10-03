using Application.Common.Interfaces.Persistence.Practice;
using Application.Common.Interfaces.Persistence.Vocabulary;
using Application.Practice.Exercises.Common;
using Domain.Practice.Exercises;
using Domain.Practice.Lessons.Errors;
using ErrorOr;
using MediatR;

namespace Application.Practice.Exercises.Queries.GetRandomExercise;

public class GetRandomExerciseQueryHandler(
    IExerciseRepository _exerciseRepository, 
    ILessonRepository _lessonRepository,
    IVocabularyRepository _vocabularyRepository) : IRequestHandler<GetRandomExerciseQuery, ErrorOr<Exercise>>
{
    private const int WordGroupSize = 6;
    
    public async Task<ErrorOr<Exercise>> Handle(GetRandomExerciseQuery request, CancellationToken cancellationToken)
    {
        if (!await _lessonRepository.ExistsAsync(request.LessonId, cancellationToken))
        {
            return LessonErrors.NotFound;
        }

        var exercise = await _exerciseRepository.GetRandomExerciseAsync(request.LessonId, cancellationToken);

        List<ExerciseResult.WordGroup> wordGroups = new();
        
        foreach (var word in exercise.Words.OrderBy(x => x.Number.Value))
        {
            var words = await _vocabularyRepository.GetRandomAsync(word, WordGroupSize - 1, cancellationToken);
        }

        return exercise;
    }
}