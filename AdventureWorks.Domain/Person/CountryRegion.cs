using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AdventureWorks.Domain.Core;
using AdventureWorks.Domain.Sales;

namespace AdventureWorks.Domain.Person
{
    public class CountryRegion : EntityBase
    {
        [Key]
        public string CountryRegionCode { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CountryRegionCurrency> CountryRegionCurrency { get; set; } = new HashSet<CountryRegionCurrency>();
        public virtual ICollection<SalesTerritory> SalesTerritory { get; set; } = new HashSet<SalesTerritory>();
        public virtual ICollection<StateProvince> StateProvince { get; set; } = new HashSet<StateProvince>();
    }
}
