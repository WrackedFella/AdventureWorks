using AdventureWorks.Core;
using System.Collections.Generic;

namespace AdventureWorks.Dal.Person
{
	public class ContactType : EntityBase
	{
		public int ContactTypeId { get; set; }
		public string Name { get; set; }

		public virtual ICollection<BusinessEntityContact> BusinessEntityContact { get; set; } = new HashSet<BusinessEntityContact>();
	}
}
