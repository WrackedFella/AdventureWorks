using System;
using AdventureWorks.Core;

namespace AdventureWorks.Domain.Sales
{
	public class SalesTerritoryHistory : EntityBase
	{
		public int BusinessEntityId { get; set; }
		public int TerritoryId { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime? EndDate { get; set; }
		public Guid Rowguid { get; set; }

		public virtual SalesPerson BusinessEntity { get; set; }
		public virtual SalesTerritory Territory { get; set; }
	}
}
