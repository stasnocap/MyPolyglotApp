using Application.Common.Interfaces.Persistence;
using Application.Practice.Exercises.Common;
using Domain.Practice.Exercises;
using Domain.Practice.Exercises.ValueObjects;
using Domain.Practice.Lessons.Errors;
using ErrorOr;
using MediatR;

namespace Application.Practice.Exercises.Queries.GetRandomExercise;

public class GetRandomExerciseQueryHandler(IExerciseRepository _exerciseRepository, ILessonRepository _lessonRepository) : IRequestHandler<GetRandomExerciseQuery, ErrorOr<Exercise>>
{
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
            switch (word.Type)
            {
                case WordType.Adjective:
                    // wordGroups.Add(new ExerciseResult.WordGroup(, word.Type));
                    break;
                case WordType.Adverb:
                    break;
                case WordType.City:
                    break;
                case WordType.ComparisonAdjective:
                    break;
                case WordType.Compound:
                    break;
                case WordType.Determiner:
                    break;
                case WordType.Language:
                    break;
                case WordType.LetterNumber:
                    break;
                case WordType.ModalVerb:
                    break;
                case WordType.Noun:
                    break;
                case WordType.NumberWithNoun:
                    break;
                case WordType.Preposition:
                    break;
                case WordType.PrimaryVerb:
                    break;
                case WordType.Pronoun:
                    break;
                case WordType.QuestionWord:
                    break;
                case WordType.Verb:
                    break;
                case WordType.None:
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        return exercise;
    }
}