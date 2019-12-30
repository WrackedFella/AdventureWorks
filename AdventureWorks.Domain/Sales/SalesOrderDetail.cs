using System;
using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.Domain.Sales
{
    public class SalesOrderDetail  : EntityBase
    {
	    [Key]
        public int SalesOrderId { get; set; }
        [Key]
        public int SalesOrderDetailId { get; set; }
        public string CarrierTrackingNumber { get; set; }
        public short OrderQty { get; set; }
        public int ProductId { get; set; }
        public int SpecialOfferId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitPriceDiscount { get; set; }
        public decimal LineTotal { get; set; }
        public Guid Rowguid { get; set; }
        
        public virtual SalesOrderHeader SalesOrder { get; set; }
        public virtual SpecialOfferProduct SpecialOfferProduct { get; set; }
    }
}
