using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AdventureWorks.Core;
using AdventureWorks.Domain.Purchasing;
using AdventureWorks.Domain.Sales;

namespace AdventureWorks.Domain.Person
{
	public class BusinessEntity : EntityBase
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int BusinessEntityId
		{
			get => this.Id;
			set => this.Id = value;
		}
		public Guid Rowguid { get; set; }

		public virtual Person Person { get; set; }
		public virtual Store Store { get; set; }
		public virtual Vendor Vendor { get; set; }
		public virtual ICollection<BusinessEntityAddress> BusinessEntityAddress { get; set; } = new HashSet<BusinessEntityAddress>();
		public virtual ICollection<BusinessEntityContact> BusinessEntityContact { get; set; } = new HashSet<BusinessEntityContact>();
	}
}
