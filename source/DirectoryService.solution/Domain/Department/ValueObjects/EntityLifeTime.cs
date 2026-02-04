namespace Domain.Department.ValueObjects;

public sealed class EntityLifeTime
{
    public static EntityLifeTime CreateNew()
    {
        DateTime newDate = DateTime.UtcNow;

        return new EntityLifeTime(newDate);
    }
    public static EntityLifeTime Create(DateTime createdAt, bool isActive , DateTime? updatedAt)
    {
        if (createdAt == DateTime.MinValue || createdAt == DateTime.MaxValue)
            throw new ArgumentException("Некоректная дата");

        if (updatedAt != null )
        {
            if (updatedAt == DateTime.MaxValue || updatedAt == DateTime.MinValue)
                throw new ArgumentException("Некоректная дата");
        }
        return new (createdAt, isActive, updatedAt);
    }
    public EntityLifeTime(DateTime createdAt, bool isActive = true, DateTime? updatedAt = null)
    {
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
        IsActive = isActive;
    }

    public DateTime CreatedAt { get; }
    public DateTime? UpdatedAt { get; }
    public bool IsActive { get; }

    /*public EntityLifeTime Update()
    {
        return new EntityLifeTime(CreatedAt, DateTime.UtcNow, IsActive);
    }*/
}