namespace Domain.Department.ValueObjects;

public sealed record Depth
{
    public Depth(short value)
    {
        if (value < 1)
            throw new ArgumentException("Глубина не может быть меньше 1.", nameof(value));
        Value = value;
    }

    public short Value { get; private set; }
}