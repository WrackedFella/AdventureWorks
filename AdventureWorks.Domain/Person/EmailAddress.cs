using System;
using System.ComponentModel.DataAnnotations;
using AdventureWorks.Domain.Core;

namespace AdventureWorks.Domain.Person
{
    public class EmailAddress : EntityBase
    {
	    [Key]
        public int BusinessEntityId { get; set; }
        [Key]
        public int EmailAddressId { get; set; }
        public string EmailAddress1 { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Person BusinessEntity { get; set; }
    }
}
