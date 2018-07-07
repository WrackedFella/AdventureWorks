using System;
using AdventureWorks.Core;

namespace AdventureWorks.Repository.Purchasing.Models
{
	public class PurchaseOrderHeaderModel : ModelBase
	{
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

		public string EmployeeDisplayName { get; set; }
		public string VendorDisplayName { get; set; }
	}
}
