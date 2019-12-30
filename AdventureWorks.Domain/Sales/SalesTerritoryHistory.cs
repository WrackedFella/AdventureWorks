using System;
using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.Domain.Sales
{
    public class SalesTerritoryHistory  : EntityBase
    {
	    [Key]
        public int BusinessEntityId { get; set; }
        [Key]
        public int TerritoryId { get; set; }
        [Key]
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Guid Rowguid { get; set; }
        
        public virtual SalesPerson BusinessEntity { get; set; }
        public virtual SalesTerritory Territory { get; set; }
    }
}
