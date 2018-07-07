using AdventureWorks.Core;
using System.Collections.Generic;

namespace AdventureWorks.Dal.Person
{
	public class PhoneNumberType : EntityBase
	{
		public int PhoneNumberTypeId { get; set; }
		public string Name { get; set; }

		public virtual ICollection<PersonPhone> PersonPhone { get; set; } = new HashSet<PersonPhone>();
	}
}
