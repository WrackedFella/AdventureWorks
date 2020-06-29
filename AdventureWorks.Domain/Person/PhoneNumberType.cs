using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AdventureWorks.Domain.Core;

namespace AdventureWorks.Domain.Person
{
    public class PhoneNumberType : EntityBase
    {
	    [Key]
        public int PhoneNumberTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PersonPhone> PersonPhone { get; set; } = new HashSet<PersonPhone>();
    }
}
