using System;
using System.ComponentModel.DataAnnotations;
using AdventureWorks.Domain.Person;

namespace AdventureWorks.Domain.Sales
{
    public class CountryRegionCurrency  : EntityBase
    {
	    [Key]
        public string CountryRegionCode { get; set; }
        [Key]
        public string CurrencyCode { get; set; }
        
        public virtual CountryRegion CountryRegionCodeNavigation { get; set; }
        public virtual Currency CurrencyCodeNavigation { get; set; }
    }
}
