using System.Collections.Generic;
using AdventureWorks.Core;

namespace AdventureWorks.Domain.Sales
{
	public class Currency : EntityBase
	{
		public string CurrencyCode { get; set; }
		public string Name { get; set; }

		public virtual ICollection<CountryRegionCurrency> CountryRegionCurrency { get; set; } = new HashSet<CountryRegionCurrency>();
		public virtual ICollection<CurrencyRate> CurrencyRateFromCurrencyCodeNavigation { get; set; } = new HashSet<CurrencyRate>();
		public virtual ICollection<CurrencyRate> CurrencyRateToCurrencyCodeNavigation { get; set; } = new HashSet<CurrencyRate>();
	}
}
