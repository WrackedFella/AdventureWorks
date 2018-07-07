using AdventureWorks.Core;
using AdventureWorks.Dal.Purchasing;
using AdventureWorks.Dal.Sales;
using System;
using System.Collections.Generic;

namespace AdventureWorks.Dal.Person
{
	public class BusinessEntity : EntityBase
	{
		public int BusinessEntityId { get; set; }
		public Guid Rowguid { get; set; }

		public virtual Person Person { get; set; }
		public virtual Store Store { get; set; }
		public virtual Vendor Vendor { get; set; }
		public virtual ICollection<BusinessEntityAddress> BusinessEntityAddress { get; set; } = new HashSet<BusinessEntityAddress>();
		public virtual ICollection<BusinessEntityContact> BusinessEntityContact { get; set; } = new HashSet<BusinessEntityContact>();
	}
}
