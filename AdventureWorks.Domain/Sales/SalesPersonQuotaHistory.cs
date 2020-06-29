using System;
using System.ComponentModel.DataAnnotations;
using AdventureWorks.Domain.Core;

namespace AdventureWorks.Domain.Sales
{
    public class SalesPersonQuotaHistory  : EntityBase
    {
	    [Key]
        public int BusinessEntityId { get; set; }
        [Key]
        public DateTime QuotaDate { get; set; }
        public decimal SalesQuota { get; set; }
        public Guid Rowguid { get; set; }
        
        public virtual SalesPerson BusinessEntity { get; set; }
    }
}
