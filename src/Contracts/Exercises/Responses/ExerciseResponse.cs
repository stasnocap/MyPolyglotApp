namespace Contracts.Exercises.Responses;

public record ExerciseResponse(Guid ExerciseId, int LessonNumber, string RusPhrase, IReadOnlyList<ExerciseResponse.WordGroup> WordGroups, ExerciseResponse.Rating? ScoreRating)
{
    public record WordGroup(IReadOnlyList<string> Words, WordType Type);

    public record Rating(int CorrectNumber, int WrongNumber, float Rate);
    
    public enum WordType
    {
        None = 0,
        Adjective = 1,
        Adverb = 2,
        City = 3,
        ComparisonAdjective = 4,
        Compound = 5,
        Determiner = 6,
        Language = 7,
        LetterNumber = 8,
        ModalVerb = 9,
        Noun = 10,
        NumberWithNoun = 11,
        Preposition = 12,
        PrimaryVerb = 13,
        Pronoun = 14,
        QuestionWord = 15,
        Verb = 16,
    }
}