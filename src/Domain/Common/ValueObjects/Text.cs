﻿using Domain.Common.Errors;
using Domain.Common.Models;
using ErrorOr;

namespace Domain.Common.ValueObjects;

public sealed class Text : ValueObject
{
    public string Value { get; }

    private Text(string value)
    {
        Value = value;
    }

    public static ErrorOr<Text> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return BaseWordErrors.Empty;
        }

        return new Text(value);
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}