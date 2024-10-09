using System.Text.RegularExpressions;
using Domain.Common.Errors;
using Domain.Common.Models;
using ErrorOr;

namespace Domain.Common.ValueObjects;

public sealed class Text : ValueObject
{
    public string Value { get; }

    public static explicit operator string(Text text) => text.Value;

    private Text(string value)
    {
        Value = value;
    }

    public Text GetWord()
    {
        var word = Regex.Match(Value, @"(more |most |\d )?[a-zA-Z0-9'-]+( not\b)?").Value.ToLower();
        return Create(word).Value;
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