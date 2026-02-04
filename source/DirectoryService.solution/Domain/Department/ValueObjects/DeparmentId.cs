namespace Domain.Department.ValueObjects;

public sealed record DepartmentId(Guid Value)
{
    public DepartmentId() : this(Guid.NewGuid()) { }
}