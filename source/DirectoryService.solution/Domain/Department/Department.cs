// Domain/Department/Department.cs
using Domain.Department.ValueObjects;
using System;

namespace Domain.Department
{
    // Интерфейс — должен быть в том же пространстве имён, что и реализация
    public interface ILifeTimeUpdatable
    {
        EntityLifeTime LifeTime { get; set; }
    }

    /// <summary>
    /// Отдел — иерархическая сущность с поддержкой жизненного цикла, уникальности и защиты от циклов.
    /// Реализует ILifeTimeUpdatable для фиксации времени обновления.
    /// </summary>
    public sealed class Department : ILifeTimeUpdatable
    {
        public Department(
            DepartmentId id,
            DepartmentId? parentId,
            Name name,
            Identifier identifier,
            DepartmentPath path,
            Depth depth,
            EntityLifeTime lifeTime)
        {
            Id = id;
            ParentId = parentId;
            Name = name;
            Identifier = identifier;
            Path = path;
            Depth = depth;
            LifeTime = lifeTime;
        }

        public DepartmentId Id { get; }
        public DepartmentId? ParentId { get; private set; }
        public Name Name { get; private set; }
        public Identifier Identifier { get; private set; }
        public DepartmentPath Path { get; private set; }
        public Depth Depth { get; private set; }
        public EntityLifeTime LifeTime { get; set; }

        // --- Методы обновления ---

        public void Rename(Name newName)
        {
            Name = newName;
            UpdateLastUpdatedDate();
        }

        public void ChangeIdentifier(IDepartmentIdentifierUniquenessCriteria criteria, Identifier newIdentifier)
        {
            if (!criteria.IsSatisfiedBy(newIdentifier))
                throw new InvalidOperationException("Идентификатор уже используется.");
            Identifier = newIdentifier;
            UpdateLastUpdatedDate();
        }

        public void ChangePath(IDepartmentPathUniquenessCriteria criteria, DepartmentPath newPath)
        {
            if (!criteria.IsSatisfiedBy(newPath))
                throw new InvalidOperationException("Путь уже занят.");
            Path = newPath;
            UpdateLastUpdatedDate();
        }

        /// <summary>
        /// Присоединяет другой отдел как дочерний.
        /// Проверяет:
        /// - нельзя присоединить к самому себе;
        /// - нельзя создать цикл (присоединить к своему потомку);
        /// - уникальность пути.
        /// </summary>
        public void AttachChild(Department child)
        {
            if (child.Id == Id)
                throw new InvalidOperationException("Отдел не может быть присоединён к самому себе.");

            if (Id == child.ParentId)
                throw new InvalidOperationException("Нельзя присоединить отдел к своему потомку.");

            // Обновляем child
            child.ParentId = Id;
            child.Path = new DepartmentPath($"{Path.Value.TrimEnd('.')}.{child.Name.Value}");
            child.Depth = new Depth((short)(Depth.Value + 1));
            
            /*if (!pathCriteria.IsSatisfiedBy(child.Path))
                throw new InvalidOperationException("Путь уже занят.");*/

            UpdateLastUpdatedDate();
        }

        // --- Вспомогательные методы ---

        private bool IsDescendantOf(Department potentialAncestor)
        {
            var current = this;
            while (current.ParentId is not null)
            {
                if (current.ParentId == potentialAncestor.Id)
                    return true;
               /* current = getById(current.ParentId.Value);
                if (current == null) break;*/
            }
            return false;
        }

        private void UpdateLastUpdatedDate()
        {
            LifeTime = LifeTime.Update();
        }

        public override string ToString() => $"{Name} ({Identifier}) at {Path}";
    }

    // === Интерфейсы уникальности ===

    public interface IDepartmentIdentifierUniquenessCriteria
    {
        bool IsSatisfiedBy(Identifier identifier);
    }

    public interface IDepartmentPathUniquenessCriteria
    {
        bool IsSatisfiedBy(DepartmentPath path);
    }
}