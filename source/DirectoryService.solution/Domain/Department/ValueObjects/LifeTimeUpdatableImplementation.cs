namespace Domain.Shared;

public static class LifeTimeUpdatableImplementation
{
    public static void UpdateLastUpdatedDate(this ILifeTimeUpdatable entity)
    {
        entity.LifeTime = entity.LifeTime.Update();
    }
}