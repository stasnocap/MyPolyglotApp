using Application.Common.Interfaces.Persistence.Identity;
using Application.Common.Interfaces.Persistence.Practice;
using Domain.Identity.Errors;
using Domain.Practice.Lessons.Errors;
using Domain.Practice.Scores.Events;
using MediatR;

namespace Application.Practice.Scores.Events;

public class ScoreCreatedDomainEventHandler(
    IUserRepository _userRepository,
    ILessonRepository _lessonRepository) : INotificationHandler<ScoreCreatedDomainEvent>
{
    public async Task Handle(ScoreCreatedDomainEvent notification, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetAsync(notification.Score.UserId, cancellationToken);

        if (user is null)
        {
            throw new Exception(UserErrors.NotFound.ToString());
        }
        
        user.AddScore(notification.Score.Id);

        var lesson = await _lessonRepository.GetAsync(notification.Score.LessonId, cancellationToken);

        if (lesson is null)
        {
            throw new Exception(LessonErrors.NotFound.ToString());
        }
        
        lesson.AddScore(notification.Score.Id);
    }
}