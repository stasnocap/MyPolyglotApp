using ErrorOr;

namespace Domain.Lessons.Errors;

public static class LessonErrors
{
    public static readonly Error EmptyName = Error.Validation("Lesson.EmptyName", "Lesson name can't be empty.");
    public static readonly Error NegativeNumber = Error.Validation("Lesson.NegativeNumber", "Lesson number can't be negative or zero.");
}