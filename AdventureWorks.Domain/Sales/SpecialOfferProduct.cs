using System;
using System.Collections.Generic;
using AdventureWorks.Core;
using AdventureWorks.Domain.Production;

namespace AdventureWorks.Domain.Sales
{
	public class SpecialOfferProduct : EntityBase
	{
		public int SpecialOfferId { get; set; }
		public int ProductId { get; set; }
		public Guid Rowguid { get; set; }

		public virtual Product Product { get; set; }
		public virtual SpecialOffer SpecialOffer { get; set; }
		public virtual ICollection<SalesOrderDetail> SalesOrderDetail { get; set; } = new HashSet<SalesOrderDetail>();
	}
}
