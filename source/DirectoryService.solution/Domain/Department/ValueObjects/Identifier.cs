using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace Domain.Department.ValueObjects;

public sealed record Identifier
{
    //private static readonly Regex LatinOnly = new(@"^[a-zA-Z]+$", RegexOptions.Compiled);

    public Identifier(string value)
    {
        Value = value;
    }
    public static Identifier Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Идентификатор не может быть пустым.", nameof(value));
        return new Identifier(value);
    }
    public string Value { get; }
}