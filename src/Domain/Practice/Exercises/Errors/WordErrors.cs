﻿using ErrorOr;

namespace Domain.Practice.Exercises.Errors;

public static class WordErrors
{
    public static readonly Error NegativeNumber = Error.Validation("Word.NegativeNumber", "Word number can't be negative or zero.");
    public static readonly Error EmptyText = Error.Validation("Word.EmptyText", "Word text can't be empty.");
}