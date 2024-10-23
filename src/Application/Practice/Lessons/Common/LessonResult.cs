using Domain.Practice.Lessons.ValueObjects;

namespace Application.Practice.Lessons.Common;

public record LessonResult(LessonId LessonId, LessonNumber Number, LessonName Name, float? Rate);