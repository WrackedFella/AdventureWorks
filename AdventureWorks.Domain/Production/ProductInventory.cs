using System;
using AdventureWorks.Core;

namespace AdventureWorks.Domain.Production
{
	public class ProductInventory : EntityBase
	{
		public int ProductId { get; set; }
		public short LocationId { get; set; }
		public string Shelf { get; set; }
		public byte Bin { get; set; }
		public short Quantity { get; set; }
		public Guid Rowguid { get; set; }

		public virtual Location Location { get; set; }
		public virtual Product Product { get; set; }
	}
}
