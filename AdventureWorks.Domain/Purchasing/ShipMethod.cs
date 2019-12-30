using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AdventureWorks.Domain.Sales;

namespace AdventureWorks.Domain.Purchasing
{
    public class ShipMethod : EntityBase
    {
	    [Key]
        public int ShipMethodId { get; set; }
        public string Name { get; set; }
        public decimal ShipBase { get; set; }
        public decimal ShipRate { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeader { get; set; } = new HashSet<PurchaseOrderHeader>();
        public virtual ICollection<SalesOrderHeader> SalesOrderHeader { get; set; } = new HashSet<SalesOrderHeader>();
    }
}
