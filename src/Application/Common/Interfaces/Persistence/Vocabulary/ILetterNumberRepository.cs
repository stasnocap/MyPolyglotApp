﻿using Domain.Practice.Exercises.Entities;

namespace Application.Common.Interfaces.Persistence.Vocabulary;

public interface ILetterNumberRepository
{
    Task<IReadOnlyList<string>> GetRandomLetterNumbers(Word word, int count, CancellationToken cancellationToken);
}