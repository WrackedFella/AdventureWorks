using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.Domain.Sales
{
    public class Customer  : EntityBase
    {
	    [Key]
        public int CustomerId { get; set; }
        public int? PersonId { get; set; }
        public int? StoreId { get; set; }
        public int? TerritoryId { get; set; }
        public string AccountNumber { get; set; }
        public Guid Rowguid { get; set; }
        
        public virtual Person.Person Person { get; set; }
        public virtual Store Store { get; set; }
        public virtual SalesTerritory Territory { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeader { get; set; } = new HashSet<SalesOrderHeader>();
    }
}
