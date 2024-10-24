using Domain.Common.ValueObjects;
using Domain.Vocabulary.Adjectives.ValueObjects;

namespace Application.Vocabulary.Adjectives.Common;

public record AdjectiveResult(AdjectiveId Id, Text Text);