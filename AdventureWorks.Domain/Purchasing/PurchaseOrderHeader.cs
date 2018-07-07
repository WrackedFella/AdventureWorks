using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AdventureWorks.Core;
using AdventureWorks.Domain.HumanResources;

namespace AdventureWorks.Domain.Purchasing
{
	public class PurchaseOrderHeader : EntityBase
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int PurchaseOrderId
		{
			get => this.Id;
			set => this.Id = value;
		}
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

		public virtual Employee Employee { get; set; }
		public virtual ShipMethod ShipMethod { get; set; }
		public virtual Vendor Vendor { get; set; }
		public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetail { get; set; } = new HashSet<PurchaseOrderDetail>();
	}
}
