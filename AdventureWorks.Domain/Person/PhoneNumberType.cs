using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.Domain.Person
{
    public class PhoneNumberType : EntityAuditBase
    {
	    [Key]
        public int PhoneNumberTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PersonPhone> PersonPhone { get; set; } = new HashSet<PersonPhone>();
    }
}
