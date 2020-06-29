using System.ComponentModel.DataAnnotations;
using AdventureWorks.Domain.Core;

namespace AdventureWorks.Domain.Sales
{
    public class SalesOrderHeaderSalesReason  : EntityBase
    {
	    [Key]
        public int SalesOrderId { get; set; }
        [Key]
        public int SalesReasonId { get; set; }
        
        public virtual SalesOrderHeader SalesOrder { get; set; }
        public virtual SalesReason SalesReason { get; set; }
    }
}
