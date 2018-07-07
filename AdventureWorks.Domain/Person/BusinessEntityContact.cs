using System;
using AdventureWorks.Core;

namespace AdventureWorks.Domain.Person
{
	public class BusinessEntityContact : EntityBase
	{
		public int BusinessEntityId { get; set; }
		public int PersonId { get; set; }
		public int ContactTypeId { get; set; }
		public Guid Rowguid { get; set; }

		public virtual BusinessEntity BusinessEntity { get; set; }
		public virtual ContactType ContactType { get; set; }
		public virtual Person Person { get; set; }
	}
}
