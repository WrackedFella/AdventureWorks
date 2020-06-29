using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AdventureWorks.Domain.Core
{
    public abstract class TypeSafeEnum : IComparable
    {
        public int Value { get; }
        public string Name { get; }

        protected TypeSafeEnum(int value, string name)
        {
            this.Value = value;
            this.Name = name;
        }

        public override string ToString() => this.Name;

        public static IEnumerable<T> GetAll<T>() where T : TypeSafeEnum
        {
            var fields = typeof(T).GetFields(BindingFlags.Public |
                                             BindingFlags.Static |
                                             BindingFlags.DeclaredOnly);

            return fields.Select(f => f.GetValue(null)).Cast<T>();
        }

        public override bool Equals(object obj)
        {
            var otherValue = obj as TypeSafeEnum;

            if (otherValue == null)
                return false;

            var typeMatches = GetType() == obj.GetType();
            var valueMatches = this.Value.Equals(otherValue.Value);

            return typeMatches && valueMatches;
        }

        public int CompareTo(object other) => this.Value.CompareTo(((TypeSafeEnum)other).Value);
        
    }
}
