using AdventureWorks.Core;
using AdventureWorks.Dal.Person;

namespace AdventureWorks.Dal.Sales
{
	public class CountryRegionCurrency : EntityBase
	{
		public string CountryRegionCode { get; set; }
		public string CurrencyCode { get; set; }

		public virtual CountryRegion CountryRegionCodeNavigation { get; set; }
		public virtual Currency CurrencyCodeNavigation { get; set; }
	}
}
