using AdventureWorks.Core;
using System;
using System.Collections.Generic;

namespace AdventureWorks.Dal.Person
{
	public class AddressType : EntityBase
	{
		public int AddressTypeId { get; set; }
		public string Name { get; set; }
		public Guid Rowguid { get; set; }

		public virtual ICollection<BusinessEntityAddress> BusinessEntityAddress { get; set; } = new HashSet<BusinessEntityAddress>();
	}
}
