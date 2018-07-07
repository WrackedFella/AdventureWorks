using System.Collections.Generic;
using AdventureWorks.Core;

namespace AdventureWorks.Domain.Person
{
	public class PhoneNumberType : EntityBase
	{
		public int PhoneNumberTypeId { get; set; }
		public string Name { get; set; }

		public virtual ICollection<PersonPhone> PersonPhone { get; set; } = new HashSet<PersonPhone>();
	}
}
