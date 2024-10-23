using Application.Common.Interfaces.Persistence.Practice;
using Application.Common.Interfaces.Services;
using Application.Practice.Lessons.Common;
using MediatR;

namespace Application.Practice.Lessons.Queries.GetLessons;

public class GetLessonsQueryHandler(ILessonRepository _lessonRepository, IUserContext _userContext) : IRequestHandler<GetLessonsQuery, IReadOnlyList<LessonResult>>
{
    public async Task<IReadOnlyList<LessonResult>> Handle(GetLessonsQuery request, CancellationToken cancellationToken)
    {
        var currentUserId = _userContext.GetCurrentUserId();

        var lessons = await _lessonRepository.GetRangeAsync(currentUserId, cancellationToken);

        return lessons;
    }
}