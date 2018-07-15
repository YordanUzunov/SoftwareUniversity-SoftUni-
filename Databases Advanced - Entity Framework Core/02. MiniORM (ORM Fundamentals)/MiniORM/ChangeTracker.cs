﻿namespace MiniORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Reflection;

    internal class ChangeTracker<TEntity>
        where TEntity : class, new()
    {
        private readonly List<TEntity> allEntities;

        private readonly List<TEntity> added;

        private readonly List<TEntity> removed;

        public ChangeTracker(IEnumerable<TEntity> entities)
        {
            this.allEntities = CloneEntities(entities.ToList()).ToList();

            this.added = new List<TEntity>();

            this.removed = new List<TEntity>();
        }

        private static IEnumerable<TEntity> CloneEntities(IEnumerable<TEntity> entities)
        {
            var clonedEntities = new List<TEntity>();

            var propertiesToClone = typeof(TEntity).GetProperties()
                .Where(pi => AllowedSqlTypes.SqlTypes.Contains(pi.PropertyType))
                .ToArray();

            foreach (var entity in entities)
            {
                var clonedInstance = new TEntity();

                foreach (var propertyInfo in propertiesToClone)
                {
                    var originalValue = propertyInfo.GetValue(entity);
                    propertyInfo.SetValue(clonedInstance, originalValue);
                }

                clonedEntities.Add(clonedInstance);
            }

            return clonedEntities;
        }

        public IReadOnlyCollection<TEntity> AllEntities => this.allEntities.AsReadOnly();

        public IReadOnlyCollection<TEntity> Added => this.added.AsReadOnly();

        public IReadOnlyCollection<TEntity> Removed => this.removed.AsReadOnly();

        public DbSet<TEntity> DbSet { get; set; }

        public void Add(TEntity item) => this.added.Add(item);

        public void Remove(TEntity item) => this.removed.Add(item);

        public IEnumerable<object> GetPrimaryKeyValues(IEnumerable<PropertyInfo> primaryKeys, TEntity entity)
        {
            var primaryKeyProperties = primaryKeys
                .Select(pi => pi.GetValue(entity))
                .ToArray();

            return primaryKeyProperties;
        }

        public IEnumerable<TEntity> GetModifiedEntities(DbSet<TEntity> dbSet)
        {
            var modifiedEntities = new List<TEntity>();

            var primaryKeys = typeof(TEntity)
                .GetProperties()
                .Where(pi => pi.HasAttribute<KeyAttribute>())
                .ToArray();

            foreach (var originalEntity in this.AllEntities)
            {
                var primaryKeyValues = GetPrimaryKeyValues(primaryKeys, originalEntity).ToArray();

                var dbSetEntity = dbSet.Entities.Single(e => GetPrimaryKeyValues(primaryKeys, e).SequenceEqual(primaryKeyValues));

                var isModified = IsModified(originalEntity, dbSetEntity);
                if (isModified)
                {
                    modifiedEntities.Add(dbSetEntity);
                }
            }

            return modifiedEntities;
        }

        public static bool IsModified(TEntity entity, TEntity clonedEntity)
        {
            var monitoredProperties = typeof(TEntity).GetProperties()
                .Where(pi => AllowedSqlTypes.SqlTypes.Contains(pi.PropertyType))
                .ToArray();

            var modifiedProperties = monitoredProperties
                .Where(pi => pi.GetValue(clonedEntity) != pi.GetValue(entity))
                .ToArray();

            var isModified = modifiedProperties.Any();
            return isModified;
        }
    }
}