using System.Text.RegularExpressions;
using Domain.Practice.Exercises.Entities;

namespace Domain.Practice.Exercises.Services;

public static class WordDecorator
{
    public static void Decorate(Word word, List<string> words)
    {
        if (char.IsUpper(word.Text.Value[0]))
        {
            UpperCaseFirstLetter(words);
        }

        var match = Regex.Match(word.Text.Value, @"^\w+(\W)$");
        if (match.Success)
        {
            AppendSymbol(words, match.Groups[1].Value);
        }
    }

    private static void AppendSymbol(List<string> words, string symbol)
    {
        for (int i = 0; i < words.Count; i++)
        {
            var wordStr = words[i];
            words[i] = $"{wordStr}{symbol}";
        }
    }

    private static void UpperCaseFirstLetter(List<string> words)
    {
        for (int i = 0; i < words.Count; i++)
        {
            var wordStr = words[i];
            words[i] = $"{wordStr[0].ToString().ToUpper()}{wordStr[1..]}";
        }
    }
}