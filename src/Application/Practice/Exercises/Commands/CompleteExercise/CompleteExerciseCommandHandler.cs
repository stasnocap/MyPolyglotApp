using Application.Common.Interfaces.Persistence.Practice;
using Application.Common.Interfaces.Services;
using Domain.Practice.Exercises.Errors;
using Domain.Practice.Scores;
using MediatR;
using ErrorOr;

namespace Application.Practice.Exercises.Commands.CompleteExercise;

public class CompleteExerciseCommandHandler(
    IExerciseRepository _exerciseRepository,
    IScoreRepository _scoreRepository,
    IUserContext _userContext) : IRequestHandler<CompleteExerciseCommand, ErrorOr<CompleteExerciseResult>>
{
    public async Task<ErrorOr<CompleteExerciseResult>> Handle(CompleteExerciseCommand request, CancellationToken cancellationToken)
    {
        var answer = await _exerciseRepository.GetAnswerAsync(request.ExerciseId, cancellationToken);

        if (answer is null)
        {
            return ExerciseErrors.NotFound;
        }

        var correctAnswer = request.Answer == answer;

        var currentUserId = _userContext.GetCurrentUserId();
        
        if (currentUserId is null)
        {
            return new CompleteExerciseResult(Success: correctAnswer, answer);
        }

        var score = await _scoreRepository.GetAsync(request.LessonId, currentUserId.Value, cancellationToken);

        if (score is null)
        {
            score = Score.Create(currentUserId.Value, request.LessonId);
            _scoreRepository.Add(score);
        }

        if (correctAnswer)
        {
            score.ScoreValue.Increase();
        }
        else
        {
            score.ScoreValue.Decrease();
        }

        return new CompleteExerciseResult(Success: correctAnswer, answer);
    }
}