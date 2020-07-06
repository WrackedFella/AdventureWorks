using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdventureWorks.Domain.Core;

namespace AdventureWorks.Domain.Enums
{
    public sealed class Status : TypeSafeEnum
    {
        private static readonly Dictionary<int, Status> Instance = new Dictionary<int, Status>();
        public static readonly Status Expired = new Status(0, "Expired");
        public static readonly Status Active = new Status(1, "Active");
        public static readonly Status Inactive = new Status(2, "Inactive");

        private Status(int value, string name) : base(value, name)
        {
            Instance[value] = this;
        }

        public static explicit operator Status(int value)
        {
            if (Instance.TryGetValue(value, out var result))
                return result;
            else
                throw new InvalidCastException();
        }

        public static explicit operator int(Status v)
        {
            return v.Value;
        }

        public static IList<(string, string)> ToList()
        {
            return new List<Status> { Active, Inactive }
                .Select(x => (x.Name, x.Value.ToString()))
                .ToList();
        }
    }
}
