namespace Domain.Department.ValueObjects;

public sealed record Name
{
    public Name(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Имя не может быть пустым.", nameof(value));
        Value = value.Trim();
    }

    public string Value { get; private set; }
}