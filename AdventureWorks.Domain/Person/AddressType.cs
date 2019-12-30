using System;
using System.Collections.Generic;

namespace AdventureWorks.Domain.Person
{
    public class AddressType : EntityAuditBase
    {
        public int AddressTypeId { get; set; }
        public string Name { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<BusinessEntityAddress> BusinessEntityAddress { get; set; } = new HashSet<BusinessEntityAddress>();
    }
}
