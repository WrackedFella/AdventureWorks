using System;
using AdventureWorks.Core;

namespace AdventureWorks.Domain.Person
{
	public class BusinessEntityAddress : EntityBase
	{
		public int BusinessEntityId { get; set; }
		public int AddressId { get; set; }
		public int AddressTypeId { get; set; }
		public Guid Rowguid { get; set; }

		public virtual Address Address { get; set; }
		public virtual AddressType AddressType { get; set; }
		public virtual BusinessEntity BusinessEntity { get; set; }
	}
}
