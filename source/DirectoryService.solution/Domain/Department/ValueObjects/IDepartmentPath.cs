namespace Domain.Department.ValueObjects
{
    public interface IDepartmentPath
    {
        string Value { get; init; }

        void Deconstruct(out string Value);
        bool Equals(DepartmentPath? other);
        bool Equals(object? obj);
        int GetHashCode();
        string ToString();
    }
}