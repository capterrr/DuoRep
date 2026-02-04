using Domain.Department.ValueObjects;

namespace Domain.Shared;

public interface ILifeTimeUpdatable
{
    EntityLifeTime LifeTime { get; set; }
}