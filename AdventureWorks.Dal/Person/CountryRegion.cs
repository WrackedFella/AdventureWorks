using AdventureWorks.Core;
using AdventureWorks.Dal.Sales;
using System.Collections.Generic;

namespace AdventureWorks.Dal.Person
{
	public class CountryRegion : EntityBase
	{
		public string CountryRegionCode { get; set; }
		public string Name { get; set; }

		public virtual ICollection<CountryRegionCurrency> CountryRegionCurrency { get; set; } = new HashSet<CountryRegionCurrency>();
		public virtual ICollection<SalesTerritory> SalesTerritory { get; set; } = new HashSet<SalesTerritory>();
		public virtual ICollection<StateProvince> StateProvince { get; set; } = new HashSet<StateProvince>();
	}
}
