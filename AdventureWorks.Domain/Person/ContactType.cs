using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.Domain.Person
{
    public class ContactType : EntityBase
    {
	    [Key]
        public int ContactTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BusinessEntityContact> BusinessEntityContact { get; set; } = new HashSet<BusinessEntityContact>();
    }
}
