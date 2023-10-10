using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using AdventureWorks.Domain.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace AdventureWorks.Domain.Extensions
{
    public static class DbContextExtensions
    {
        /// <summary>
        /// Iterates over all public properties in <paramref name="newRecord"/>
        /// and applies any modified values to <paramref name="entity"/>.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="newRecord"></param>
        public static void UpdateRecord(this EntityEntry entity, EntityBase newRecord)
        {
            //DatabaseGenerated
            var props = entity.Properties
                .Where(p =>
                    p != null
                    && p.Metadata.PropertyInfo.GetAccessors().All(x => !x.IsVirtual)
                    && !p.Metadata.IsKey()
                    && p.Metadata.FieldInfo?.DeclaringType != typeof(EntityBase)
                    && p.Metadata.PropertyInfo.CanWrite
                    && p.Metadata.PropertyInfo.CustomAttributes.All(a => a.AttributeType != typeof(DatabaseGeneratedAttribute)));
            foreach (var entityProp in props)
            {
                var modifiedProp = newRecord.GetType().GetProperties()
                    .FirstOrDefault(p => p.Name == entityProp.Metadata.Name);
                if (modifiedProp == null 
                    || modifiedProp.GetValue(newRecord) == null 
                    || modifiedProp.GetMethod != null && modifiedProp.GetMethod.ReturnType == typeof(Guid) && (Guid)modifiedProp.GetValue(newRecord) == Guid.Empty)
                {
                    continue;
                }

                var newValue = modifiedProp.GetValue(newRecord);
                var existingValue = entityProp.CurrentValue;
                if (existingValue == newValue)
                {
                    continue;
                }

                entityProp.CurrentValue = newValue;
            }
        }
    }
}
