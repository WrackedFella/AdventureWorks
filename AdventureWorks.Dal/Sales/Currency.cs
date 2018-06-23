using System;
using System.Collections.Generic;

namespace AdventureWorks.Dal.Sales
{
	public partial class Currency
	{
		public string CurrencyCode { get; set; }
		public string Name { get; set; }
		public DateTime ModifiedDate { get; set; }

		public virtual ICollection<CountryRegionCurrency> CountryRegionCurrency { get; set; } = new HashSet<CountryRegionCurrency>();
		public virtual ICollection<CurrencyRate> CurrencyRateFromCurrencyCodeNavigation { get; set; } = new HashSet<CurrencyRate>();
		public virtual ICollection<CurrencyRate> CurrencyRateToCurrencyCodeNavigation { get; set; } = new HashSet<CurrencyRate>();
	}
}
