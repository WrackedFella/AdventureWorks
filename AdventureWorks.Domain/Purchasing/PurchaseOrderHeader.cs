﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AdventureWorks.Domain.Core;
using AdventureWorks.Domain.HumanResources;

namespace AdventureWorks.Domain.Purchasing
{
    public class PurchaseOrderHeader : EntityBase
    {
	    [Key]
        public int PurchaseOrderId { get; set; }
        public byte RevisionNumber { get; set; }
        public byte Status { get; set; }
        public int EmployeeId { get; set; }
        public int VendorId { get; set; }
        public int ShipMethodId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TaxAmt { get; set; }
        public decimal Freight { get; set; }
        public decimal TotalDue { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual ShipMethod ShipMethod { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetail { get; set; } = new HashSet<PurchaseOrderDetail>();
    }
}
