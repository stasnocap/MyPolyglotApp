using Application.Exercises.Common;
using Domain.Common.Extensions;
using Domain.Exercises.ValueObjects;
using MediatR;
using ErrorOr;

namespace Application.Exercises.Queries.GetRandomExercise;

public class GetRandomExerciseQueryHandler : IRequestHandler<GetRandomExerciseQuery, ErrorOr<ExerciseResult>>
{
    public async Task<ErrorOr<ExerciseResult>> Handle(GetRandomExerciseQuery request, CancellationToken cancellationToken)
    {
        List<Error> errors = [];
        
        var exerciseId = ExerciseId.Create(Guid.NewGuid());
        
        var rusPhrase = RusPhrase.Create("Я крутой.").ElseAccumulate(errors);
        var engPhrase = EngPhrase.Create("I am cool.").ElseAccumulate(errors);

        if (errors.Count > 0)
        {
            return errors;
        }
        
        return new ExerciseResult(exerciseId, rusPhrase.Value, engPhrase.Value, [[]]);
    }
}