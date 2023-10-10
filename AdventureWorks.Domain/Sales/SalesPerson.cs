using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AdventureWorks.Domain.Core;
using AdventureWorks.Domain.HumanResources;

namespace AdventureWorks.Domain.Sales
{
    public class SalesPerson  : EntityBase
    {
	    [Key]
        public int BusinessEntityId { get; set; }
        public int? TerritoryId { get; set; }
        public decimal? SalesQuota { get; set; }
        public decimal Bonus { get; set; }
        public decimal CommissionPct { get; set; }
        public decimal SalesYtd { get; set; }
        public decimal SalesLastYear { get; set; }
        public Guid Rowguid { get; set; }
        
        public virtual Employee BusinessEntity { get; set; }
        public virtual SalesTerritory Territory { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeader { get; set; } = new HashSet<SalesOrderHeader>();
        public virtual ICollection<SalesPersonQuotaHistory> SalesPersonQuotaHistory { get; set; } = new HashSet<SalesPersonQuotaHistory>();
        public virtual ICollection<SalesTerritoryHistory> SalesTerritoryHistory { get; set; } = new HashSet<SalesTerritoryHistory>();
        public virtual ICollection<Store> Store { get; set; } = new HashSet<Store>();
    }
}
