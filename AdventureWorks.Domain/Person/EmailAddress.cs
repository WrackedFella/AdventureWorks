using System;
using AdventureWorks.Core;

namespace AdventureWorks.Domain.Person
{
	public class EmailAddress : EntityBase
	{
		public int BusinessEntityId { get; set; }
		public int EmailAddressId { get; set; }
		public string EmailAddress1 { get; set; }
		public Guid Rowguid { get; set; }

		public virtual Person BusinessEntity { get; set; }
	}
}
