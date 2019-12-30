using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.Domain.Sales
{
    public class SalesReason  : EntityBase
    {
	    [Key]
        public int SalesReasonId { get; set; }
        public string Name { get; set; }
        public string ReasonType { get; set; }
        
        public virtual ICollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReason { get; set; } = new HashSet<SalesOrderHeaderSalesReason>();
    }
}
