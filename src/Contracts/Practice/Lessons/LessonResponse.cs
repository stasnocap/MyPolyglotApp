namespace Contracts.Practice.Lessons;

public record LessonResponse(Guid LessonId, int Number, string Name, float? Rate);