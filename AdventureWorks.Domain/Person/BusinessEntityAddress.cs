using System;
using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.Domain.Person
{
    public class BusinessEntityAddress : EntityBase
    {
	    [Key]
        public int BusinessEntityId { get; set; }
        [Key]
        public int AddressId { get; set; }
        [Key]
        public int AddressTypeId { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Address Address { get; set; }
        public virtual AddressType AddressType { get; set; }
        public virtual BusinessEntity BusinessEntity { get; set; }
    }
}
